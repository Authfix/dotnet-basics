namespace DesignPatterns.Facade.SubSystems
{
    internal class UserDbContext
    {
        private readonly List<string> _users;

        public UserDbContext()
        {
            _users = new List<string>();
        }

        public void AddUser(string user)
        {
            _users.Add(user);
        }
    }
}
