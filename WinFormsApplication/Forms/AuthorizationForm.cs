using WinFormsApplication.Exceptions;
using WinFormsApplication.Singletons;
using WinFormsApplication.Singletons.Impl;

namespace WinFormsApplication.Forms
{
    public partial class AuthorizationForm : Form
    {
        private EditContext _editContext;

        public AuthorizationForm()
        {
            InitializeComponent();

            _editContext = new();

            _editContext.Create(loginTextBox, loginLabel,
                EditContextHelper.StringLength(() => loginTextBox.Text, 5, 64));

            _editContext.Create(passwordTextBox, passwordLabel,
                EditContextHelper.StringLength(() => passwordTextBox.Text, 5, 64));
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            var registrationForm = new RegistrationForm();

            Opacity = 0;

            ShowInTaskbar = false;

            registrationForm.FormClosed += OnRegistrationFormClosed;

            registrationForm.Show();
        }

        private void OnRegistrationFormClosed(object? sender, FormClosedEventArgs e)
        {
            if (Authorization.Instance.IsAuthorized)
            {
                Close();

                return;
            }

            Opacity = 1;

            ShowInTaskbar = true;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (!_editContext.Verify())
            {
                return;
            }

            try
            {
                Authorization.Instance.SignIn(loginTextBox.Text, passwordTextBox.Text);

                Close();
            }
            catch (InvalidAuthorizationException ex)
            {
                loginLabel.ForeColor = Color.Red;
                loginTextBox.ForeColor = Color.Red;

                passwordLabel.ForeColor = Color.Red;
                passwordTextBox.ForeColor = Color.Red;

                errorLabel.Visible = true;
            }
        }
    }
}
