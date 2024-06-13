namespace WinFormsApplication.Exceptions
{
    public class InvalidAuthorizationException : Exception
    {
        public InvalidAuthorizationException() : base("Непрвильный логин или пароль")
        {
        }
    }
}
