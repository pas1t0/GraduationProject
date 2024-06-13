using Database;
using Database.Entities;
using WinFormsApplication.Singletons;
using WinFormsApplication.Singletons.Impl;

namespace WinFormsApplication.Forms
{
    public partial class CreateRequestForm : Form
    {
        private readonly EditContext _editContext;
        private readonly Service _service;

        public CreateRequestForm(Service service)
        {
            _service = service;

            _editContext = new EditContext();

            InitializeComponent();

            serveTimePicker.MinDate = DateTime.Now;

            _editContext.Create(addressTextBox, addressLabel,
                EditContextHelper.StringLength(() => addressTextBox.Text, 5, 64));
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (_editContext.Verify() == false)
            {
                return;
            }

            using var dbContext = new DatabaseContext();

            dbContext.Requests.Add(new()
            {
                ServiceId = _service.Id,
                UserId = UserService.Instance.AuthorizedUser.Id,
                EmployeeId = null,
                Price = _service.Price,
                CreatedTime = DateTime.Now,
                ServedTime = null,
                Address = addressTextBox.Text,
                ServeTime = serveTimePicker.Value,
                IsCompleted = false,
                IsPayed = false
            });

            dbContext.SaveChanges();

            MessageBox.Show("Заявка успешно создана");

            Close();
        }
    }
}
