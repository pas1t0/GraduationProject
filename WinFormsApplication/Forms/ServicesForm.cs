using Database;
using Database.Entities;
using Microsoft.EntityFrameworkCore;
using WinFormsApplication.Components;
using WinFormsApplication.Singletons.Impl;

namespace WinFormsApplication.Forms
{
    public partial class ServicesForm : Form
    {
        private CategoryItem _selectedCategoryItem;

        public ServicesForm()
        {
            InitializeComponent();

            using (var dbContext = new DatabaseContext())
            {
                var noneItem = new CategoryItem()
                {
                    Id = null,
                    Name = "Не выбрано"
                };

                _selectedCategoryItem = noneItem;

                var noneItemIndex = categoryComboBox.Items.Add(noneItem);

                categoryComboBox.SelectedIndex = noneItemIndex;

                categoryComboBox.Items.AddRange(dbContext.Categories
                    .Select(x => new CategoryItem()
                    {
                        Id = x.Id,
                        Name = x.Name,
                    })
                    .ToArray());
            }

            UpdateData();

            if (UserService.Instance.IsAdmin)
            {
                createButton.Visible = true;
            }
        }

        private void UpdateData()
        {
            using var dbContext = new DatabaseContext();

            servicesContainer.Controls.Clear();

            var services = dbContext.Services
                .Include(x => x.Category)
                .Where(x => _selectedCategoryItem.Id.HasValue ? x.CategoryId == _selectedCategoryItem.Id.Value : true)
                .Where(x => string.IsNullOrEmpty(searchTextBox.Text) ? true : x.Name.Contains(searchTextBox.Text));

            foreach (var service in services)
            {
                var serviceControl = new ServiceControl(service);

                if (UserService.Instance.IsAdmin)
                {
                    serviceControl.OnSubmitClick += () => OnAdminSubmit(service);

                    serviceControl.SetSubmitButton("Обновить");
                }
                else if (UserService.Instance.IsClient)
                {
                    serviceControl.OnSubmitClick += () => OnClientSubmit(service);

                    serviceControl.SetSubmitButton("Заказать");
                }

                servicesContainer.Controls.Add(serviceControl);
            }
        }

        private void OnAdminSubmit(Service service)
        {
            var updateServiceForm = new ServiceSetForm(service);

            updateServiceForm.OnValidClick += UpdateService;

            updateServiceForm.Show();
        }

        private void UpdateService(Service service)
        {
            using var dbContext = new DatabaseContext();

            var updateService = dbContext.Services.First(x => x.Id == service.Id);

            updateService.Name = service.Name;
            updateService.Description = service.Description;
            updateService.ImagePath = service.ImagePath;
            updateService.Price = service.Price;
            updateService.CategoryId = service.CategoryId;

            dbContext.Update(updateService);

            dbContext.SaveChanges();

            UpdateData();
        }

        private void OnClientSubmit(Service service)
        {
            var createRequestForm = new CreateRequestForm(service);

            createRequestForm.Show();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            var createServiceForm = new ServiceSetForm();

            createServiceForm.OnValidClick += CreateService;

            createServiceForm.Show();
        }

        private void CreateService(Service service)
        {
            using var dbContext = new DatabaseContext();

            dbContext.Services.Add(service);

            dbContext.SaveChanges();

            UpdateData();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedCategoryItem = categoryComboBox.SelectedItem as CategoryItem;

            UpdateData();
        }

        private class CategoryItem
        {
            public int? Id { get; set; }

            public string Name { get; set; }

            public override string ToString() => Name;
        }
    }
}
