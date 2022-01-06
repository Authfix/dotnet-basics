using DesignPatterns.Facade.SubSystems;

namespace DesignPatterns.Facade
{
    internal class UserFacade
    {
        private readonly SocialService _socialService;
        private readonly UserDbContext _userDb;

        public UserFacade()
        {
            _socialService = new SocialService();
            _userDb = new UserDbContext();
        }

        public void CreateUser(string userName)
        {
            _userDb.AddUser(userName);
            _socialService.CreateUserContract(userName);
        }
    }
}
