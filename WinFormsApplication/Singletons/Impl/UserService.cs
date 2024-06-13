using Database.Entities;

namespace WinFormsApplication.Singletons.Impl
{
    public class UserService : IUserService, IUserServiceSetter
    {
        private static IUserService _instance = new UserService();

        public static IUserService Instance => _instance;

        private UserService()
        {
        }

        public User AuthorizedUser { get; set; }

        public bool IsAdmin => AuthorizedUser.RoleId == 3;

        public bool IsEmployee => AuthorizedUser.RoleId == 2;

        public bool IsClient => AuthorizedUser.RoleId == 1;
    }
}
