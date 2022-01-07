namespace DesignPatterns.Singleton
{

    internal class Caching
    {
        private static Caching _instance;
        /// <summary>
        /// Gets the arena instance
        /// </summary>
        public static Caching Instance
        {
            get 
            {
                if(_instance == null) _instance = new Caching();
                return _instance;
            }
        }

        private readonly Dictionary<string, string> _dictionary;

        /// <summary>
        /// Initialize a new instance of an <see cref="Caching"/>
        /// </summary>
        private Caching()
        {
            _dictionary = new Dictionary<string, string>();
        }

        public void Add(string key, string value)
        {
            _dictionary.Add(key, value);
        }

        public string Get(string key)
        {
            var value = _dictionary[key];

            return value;
        }
    }
}
