using Database;
using Database.Entities;
using WinFormsApplication.Singletons;
using WinFormsApplication.Singletons.Impl;

namespace WinFormsApplication.Forms
{
    public partial class RegistrationForm : Form
    {
        private readonly EditContext _verificationContext;

        public RegistrationForm()
        {
            _verificationContext = new();

            InitializeComponent();

            _verificationContext.Create(firstNameTextBox, firstNameLabel,
                EditContextHelper.StringLength(() => firstNameTextBox.Text, 5, 64));

            _verificationContext.Create(middleNameTextBox, middleNameLabel,
                EditContextHelper.StringLength(() => middleNameTextBox.Text, 5, 64));

            _verificationContext.Create(lastNameTextBox, lastNameLabel,
                EditContextHelper.StringLength(() => lastNameTextBox.Text, 5, 64));

            _verificationContext.Create(phoneTextBox, phoneLabel,
                EditContextHelper.PhoneCondition(() => phoneTextBox.Text));

            _verificationContext.Create(emailTextBox, emailLabel,
                EditContextHelper.EmailCondition(() => emailTextBox.Text));

            _verificationContext.Create(loginTextBox, loginLabel,
                EditContextHelper.StringLength(() => loginTextBox.Text, 3, 32));

            _verificationContext.Create(passwordTextBox, passwordLabel,
                EditContextHelper.StringLength(() => passwordTextBox.Text, 3, 32));
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (!_verificationContext.Verify())
            {
                return;
            }

            using var dbContext = new DatabaseContext();

            dbContext.Users.Add(new User()
            {
                RoleId = 1,
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                MiddleName = middleNameTextBox.Text,
                Email = emailTextBox.Text,
                Phone = phoneTextBox.Text,
                Login = loginTextBox.Text,
                Password = passwordTextBox.Text,
            });

            dbContext.SaveChanges();

            Authorization.Instance.SignIn(loginTextBox.Text, passwordTextBox.Text);

            Close();
        }
    }
}
