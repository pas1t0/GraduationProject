using Database;
using Database.Entities;
using Microsoft.EntityFrameworkCore;
using WinFormsApplication.Singletons.Impl;

namespace WinFormsApplication.Components
{
    public partial class RequestControl : UserControl
    {
        private readonly string _executorLabelFormat;
        private readonly string _executorPositionFormat;
        private readonly string _periodLabelFormat;
        private Request _request;

        public RequestControl(Request request)
        {
            _request = request;

            InitializeComponent();

            if (request.EmployeeId is null && UserService.Instance.IsEmployee)
            {
                pinButton.Visible = true;
            }

            if (UserService.Instance.IsEmployee &&
                _request.Employee is not null &&
                _request.Employee.User.Id == UserService.Instance.AuthorizedUser.Id)
            {
                isPayedCheckbox.AutoCheck = true;
                isCompletedCheckBox.AutoCheck = true;
            }

            _executorLabelFormat = executorFullNameLabel.Text;
            _executorPositionFormat = positionLabel.Text;
            _periodLabelFormat = periodLabel.Text;
            serviceNameLabel.Text = request.Service.Name;
            serviceDescriptionLabel.Text = request.Service.Description;
            serviceImageBox.Image = ImagesContainer.Instance.Get(request.Service.ImagePath);
            customerFullNameLabel.Text = string.Format(customerFullNameLabel.Text, request.User.FullName);
            executorFullNameLabel.Text = string.Format(_executorLabelFormat, request.Employee?.User.FullName ?? "Не установлено");
            positionLabel.Text = string.Format(_executorPositionFormat, request.Employee?.Position?.Title ?? "Не установлено");
            priceLabel.Text = string.Format(priceLabel.Text, request.Price);
            periodLabel.Text = string.Format(_periodLabelFormat, request.CreatedTime.ToString(), request.ServedTime?.ToString() ?? "Не установлено");
            isCompletedCheckBox.Checked = request.IsCompleted;
            categoryLabel.Text = string.Format(categoryLabel.Text, request.Service.Category.Name);
            categoryDiscriptionLabel.Text = string.Format(categoryDiscriptionLabel.Text, request.Service.Category.Description);
            serveTimeLabel.Text = string.Format(serveTimeLabel.Text, request.ServeTime.ToShortDateString());
            addressLabel.Text = string.Format(addressLabel.Text, request.Address);
        }

        private void pinButton_Click(object sender, EventArgs e)
        {
            using var dbContext = new DatabaseContext();

            var currentEmployee = dbContext.Employees
                .Include(x => x.User)
                .Include(x => x.Position)
                .FirstOrDefault(x => x.UserId == UserService.Instance.AuthorizedUser.Id);

            if (currentEmployee is null)
            {
                return;
            }

            var request = dbContext.Requests.First(x => x.Id == _request.Id);

            request.EmployeeId = currentEmployee.Id;

            dbContext.SaveChanges();

            executorFullNameLabel.Text = string.Format(_executorLabelFormat, currentEmployee.User.FullName);
            positionLabel.Text = string.Format(_executorPositionFormat, currentEmployee.Position.Title);

            pinButton.Visible = false;
            isCompletedCheckBox.AutoCheck = true;
            isPayedCheckbox.AutoCheck = true;
        }

        private void isCompletedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            using var dbContext = new DatabaseContext();

            var request = dbContext.Requests.First(x => x.Id == _request.Id);
            
            if (request.IsPayed == false || request.IsCompleted == isCompletedCheckBox.Checked)
            {
                isCompletedCheckBox.Checked = request.IsCompleted;

                return;
            }

            request.IsCompleted = isCompletedCheckBox.Checked;
            request.ServedTime = isCompletedCheckBox.Checked ? DateTime.Now : null;
            periodLabel.Text = string.Format(_periodLabelFormat, request.CreatedTime,
                request.ServedTime?.ToString() ?? "Не установлено");

            dbContext.SaveChanges();
        }

        private void isPayedCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            using var dbContext = new DatabaseContext();

            var request = dbContext.Requests.First(x => x.Id == _request.Id);

            if (request.IsPayed == isPayedCheckbox.Checked)
            {
                return;
            }

            request.IsPayed = isPayedCheckbox.Checked;

            if (request.IsPayed == false)
            {
                request.IsCompleted = false;
                request.ServedTime = null;
            }

            dbContext.SaveChanges();

            UpdateOnChange(request);
        }

        private void UpdateOnChange(Request request)
        {
            periodLabel.Text = string.Format(_periodLabelFormat, request.CreatedTime,
                request.ServedTime?.ToString() ?? "Не установлено");

            isPayedCheckbox.Checked = request.IsPayed;

            isCompletedCheckBox.Checked = request.IsCompleted;
        }
    }
}
