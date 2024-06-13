using Database.Entities;

namespace WinFormsApplication.Singletons
{
    public interface IUserServiceSetter
    {
        public User AuthorizedUser { get; set; }
    }
}
