using Database.Entities;

namespace WinFormsApplication.Singletons
{
    public interface IUserService
    {
        public User AuthorizedUser { get; }

        public bool IsAdmin { get; }

        public bool IsEmployee { get; }

        public bool IsClient { get; }
    }
}
