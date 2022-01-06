namespace DesignPatterns.Decorator.Locked
{
    internal sealed class Disc : ILibraryItem
    {
        private readonly string _author;
        private readonly int _nbTitles;

        public Disc(string author, int nbTitles)
        {
            this._author = author;
            this._nbTitles = nbTitles;
        }

        public void DisplayName()
        {
            Console.WriteLine($"Author : {_author} Nb Titles : {_nbTitles}");
        }
    }
}
