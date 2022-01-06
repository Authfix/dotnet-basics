namespace DesignPatterns.Facade.SubSystems
{
    internal class SocialService
    {
        private readonly List<UserContract> _contracts;

        public SocialService()
        {
            _contracts = new List<UserContract>();
        }

        public void CreateUserContract(string user)
        {
            _contracts.Add(new UserContract(Guid.NewGuid(), user));
        }
    }

    internal class UserContract
    {
        public UserContract(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public Guid Id { get; init; }

        public string Name { get; init; }        
    }
}
