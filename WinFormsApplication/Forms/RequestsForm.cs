using Database;
using Microsoft.EntityFrameworkCore;
using WinFormsApplication.Components;
using WinFormsApplication.Singletons.Impl;

namespace WinFormsApplication.Forms
{
    public partial class RequestsForm : Form
    {
        public RequestsForm()
        {
            InitializeComponent();

            using (var dbContext = new DatabaseContext())
            {
                var noneItemIndex = servicesComboBox.Items.Add(new ServiceItem()
                {
                    Id = null,
                    Name = "Не выбрано"
                });

                servicesComboBox.SelectedIndex = noneItemIndex;

                servicesComboBox.Items.AddRange(dbContext.Services
                    .Select(x => new ServiceItem()
                    {
                        Id = x.Id,
                        Name = x.Name,
                    })
                    .ToArray());
            };

            UpdateData();
        }

        private void UpdateData(int? serviceId = null)
        {
            requestsContainer.Controls.Clear();

            using var dbContext = new DatabaseContext();

            foreach (var request in dbContext.Requests
                .Include(x => x.Service)
                .ThenInclude(x => x.Category)
                .Include(x => x.Employee)
                .Include(x => x.Employee.User)
                .Include(x => x.Employee.Position)
                .Include(x => x.User)
                .Where(x => UserService.Instance.IsClient ? x.UserId == UserService.Instance.AuthorizedUser.Id : true)
                .Where(x => serviceId.HasValue ? x.ServiceId == serviceId.Value : true))
            {
                var requestControl = new RequestControl(request);

                requestsContainer.Controls.Add(requestControl);
            }
        }

        private void servicesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var serviceItem = servicesComboBox.SelectedItem as ServiceItem;

            UpdateData(serviceItem.Id);
        }

        private class ServiceItem
        {
            public int? Id { get; set; }

            public string Name { get; set; }

            public override string ToString() => Name;
        }
    }
}
