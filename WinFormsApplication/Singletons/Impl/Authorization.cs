using System.Text.Json;
using Database;
using WinFormsApplication.Exceptions;

namespace WinFormsApplication.Singletons.Impl
{
    public class Authorization : IAuthorization
    {
        private static IAuthorization _instance;
        private string _credsFilePath;
        private bool _isAuthorized;

        public static IAuthorization Instance => _instance ?? (_instance = new Authorization());

        public bool IsAuthorized => _isAuthorized;

        public Authorization()
        {
            _isAuthorized = false;

            _credsFilePath = Path.Combine(Environment.CurrentDirectory, "credentials.ini");

            if (File.Exists(_credsFilePath))
            {
                TrySignInByCredentialsData();
            }
        }

        private class AuthData
        {
            public string Login { get; set; }

            public string Password { get; set; }
        }

        private void TrySignInByCredentialsData()
        {
            try
            {
                var data = JsonSerializer.Deserialize<AuthData>(File.ReadAllText(_credsFilePath));

                SignIn(data.Login, data.Password);

                return;
            }
            catch
            {
            }
        }

        public void SignOut()
        {
            _isAuthorized = false;

            if (File.Exists(_credsFilePath))
            {
                File.Delete(_credsFilePath);
            }
        }

        public void SignIn(string login, string password)
        {
            using var dbContext = new DatabaseContext();

            var user = dbContext.Users.FirstOrDefault(x => x.Password == password && x.Login == login);

            if (user is null)
            {
                throw new InvalidAuthorizationException();
            }

            _isAuthorized = true;

            if (UserService.Instance is IUserServiceSetter userSetter)
            {
                userSetter.AuthorizedUser = user;
            }
            else
            {
                throw new NotImplementedException();
            }

            if (File.Exists(_credsFilePath) == false)
            {
                var fileStream = File.Create(_credsFilePath);

                fileStream.Dispose();
            }

            var data = new AuthData
            {
                Login = login,
                Password = password
            };
            var serializedData = JsonSerializer.Serialize(data);

            File.WriteAllText(_credsFilePath, serializedData);
        }
    }
}
