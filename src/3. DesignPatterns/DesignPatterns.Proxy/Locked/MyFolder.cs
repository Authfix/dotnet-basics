namespace DesignPatterns.Proxy.Locked
{
    internal class MyFolder : IFolder
    {
        public List<string> Read()
        {
            return new List<string>()
            {
                "progz",
                "users",
                "temp"
            };
        }
    }
}
