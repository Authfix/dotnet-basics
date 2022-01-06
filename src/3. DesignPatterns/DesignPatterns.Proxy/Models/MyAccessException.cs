namespace DesignPatterns.Proxy.Models
{

    [Serializable]
    public class MyAccessException : Exception
    {
        public MyAccessException() { }
        public MyAccessException(string message) : base(message) { }
        public MyAccessException(string message, Exception inner) : base(message, inner) { }
        protected MyAccessException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
