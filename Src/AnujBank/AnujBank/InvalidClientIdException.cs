using System;

namespace AnujBank
{
    public class InvalidClientIdException : Exception
    {
        public InvalidClientIdException(string message)
            : base(message)
        {

        }
    }
}