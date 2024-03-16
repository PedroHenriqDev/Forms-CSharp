using System;

namespace Services.Exceptions
{
    public class FillException : Exception
    {
        public FillException(string message) : base(message) 
        {
        }
    }
}
