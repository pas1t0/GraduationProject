using Database;
using Database.Entities;
using WinFormsApplication.Singletons;
using WinFormsApplication.Singletons.Impl;

namespace WinFormsApplication.Forms
{
    public partial class ServiceSetForm : Form
    {
        private readonly EditContext _editContext;
        private int? _serviceId;

        private class CategoryItem
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public override string ToString()
            {
                return Name;
            }
        }

        public ServiceSetForm(Service? service = null)
        {
            _serviceId = service?.Id;

            InitializeComponent();

            _editContext = new EditContext();

            _editContext.Create(nameTextBox, nameLabel,
                EditContextHelper.StringLength(() => nameTextBox.Text, 5, 64));

            _editContext.Create(descriptionTextBox, descriptionLabel,
                EditContextHelper.StringLength(() => descriptionTextBox.Text, 5, 128));

            _editContext.Create(imageComboBox, imageLabel,
                EditContextHelper.StringLength(() => imageComboBox.Text, 5, 64));

            _editContext.Create(categoryComboBox, categoryLabel,
                () => categoryComboBox.SelectedItem is CategoryItem);

            using var dbContext = new DatabaseContext();

            imageComboBox.Items.AddRange(ImagesContainer.Instance.GetImagesPaths().ToArray());

            categoryComboBox.Items.AddRange(
                dbContext.Categories
                .Select(category =>
                    new CategoryItem()
                    {
                        Id = category.Id,
                        Name = category.Name,
                    })
                .ToArray());

            if (service is null)
            {
                Text = titleLabel.Text = "Создать услугу";

                submitButton.Text = "Создать";
            }
            else
            {
                Text = titleLabel.Text = "Обновить услугу";

                submitButton.Text = "Обновить";

                nameTextBox.Text = service.Name;
                descriptionTextBox.Text = service.Description;
                priceInput.Value = service.Price;

                foreach (CategoryItem categoryItem in categoryComboBox.Items)
                {
                    if (categoryItem.Id == service.CategoryId)
                    {
                        categoryComboBox.SelectedItem = categoryItem;

                        break;
                    }
                }

                imageComboBox.SelectedItem = service.ImagePath;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (!_editContext.Verify())
            {
                return;
            }

            OnValidClick(new Service()
            {
                Id = _serviceId ?? 0,
                Name = nameTextBox.Text,
                Description = descriptionTextBox.Text,
                CategoryId = (categoryComboBox.SelectedItem as CategoryItem).Id,
                ImagePath = imageComboBox.Text,
                Price = priceInput.Value,
                Amount = (int)amountInput.Value
            });

            Close();
        }

        public event Action<Service> OnValidClick = delegate { };

        private void imageComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            imageBox.Image = ImagesContainer.Instance.Get(imageComboBox.Text);
        }
    }
}
