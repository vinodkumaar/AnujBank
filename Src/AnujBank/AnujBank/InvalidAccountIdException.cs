using System;

namespace AnujBank
{
    public class InvalidAccountIdException : Exception
    {
        public InvalidAccountIdException(string message)
            : base(message)
        {

        }
    }
}