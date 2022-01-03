using System;

namespace MyCompany.MyGarage.Models.Exceptions
{
    [Serializable]
    internal class MyGarageException : Exception
    {
        /// <summary>
        /// Initialize a new <see cref="MyGarageException"/>
        /// </summary>
        /// <param name="message">The exception message</param>
        public MyGarageException(string message) : base(message)
        {
        }
    }
}