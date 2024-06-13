using Database;
using WinFormsApplication.Forms;
using WinFormsApplication.Singletons.Impl;

namespace WinFormsApplication
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            if (!Authorization.Instance.IsAuthorized)
            {
                ShowAuthorizationForm();
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Authorization.Instance.SignOut();

            ShowAuthorizationForm();
        }

        private void ShowForm()
        {
            Opacity = 1;

            ShowInTaskbar = true;

            Focus();
        }

        private void servicesButton_Click(object sender, EventArgs e)
        {
            var serviceForm = new ServicesForm();

            HideForm();

            serviceForm.FormClosed += (s, e) => ShowForm();

            serviceForm.Show();
        }

        private void HideForm()
        {
            Opacity = 0;

            ShowInTaskbar = false;
        }

        private void ShowAuthorizationForm()
        {
            var authorizationForm = new AuthorizationForm();

            HideForm();

            authorizationForm.FormClosed += (s, e) =>
            {
                if (!Authorization.Instance.IsAuthorized)
                {
                    Close();

                    return;
                }

                ShowForm();
            };

            authorizationForm.Show();
        }

        private void requestsButton_Click(object sender, EventArgs e)
        {
            var serviceDirectionsForm = new RequestsForm();

            HideForm();

            serviceDirectionsForm.FormClosed += (s, e) => ShowForm();

            serviceDirectionsForm.Show();
        }
    }
}
