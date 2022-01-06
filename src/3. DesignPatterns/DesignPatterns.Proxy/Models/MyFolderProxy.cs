using DesignPatterns.Proxy.Locked;

namespace DesignPatterns.Proxy.Models
{
    internal class MyFolderProxy : IFolder
    {
        private readonly IFolder _folder;
        private readonly int userId;

        public MyFolderProxy(IFolder folder, int userId)
        {
            _folder = folder;
            this.userId = userId;
        }

        public MyFolderProxy(int userId): this(new MyFolder(), userId)
        {
        }

        public List<string> Read()
        {
            if (CheckAccess())
            {
                return _folder.Read();
            }               

            throw new MyAccessException("You do not have access");
        }

        private bool CheckAccess()
        {
            if(userId != 0)
            {
                return false;
            }

            return true;
        }
    }
}
