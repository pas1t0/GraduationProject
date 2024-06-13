namespace WinFormsApplication.Singletons
{
    public interface IAuthorization
    {
        public bool IsAuthorized { get; }

        public void SignIn(string login, string password);

        public void SignOut();
    }
}
