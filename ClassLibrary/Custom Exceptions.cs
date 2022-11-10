using System;

namespace ClassLibrary
{
    public class WrongKeyValue : Exception
    {
        public WrongKeyValue(string message) : base(message)
        { }
    }
}