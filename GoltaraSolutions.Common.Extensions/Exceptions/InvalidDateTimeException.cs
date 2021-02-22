using System;

namespace GoltaraSolutions.Common.Extensions.Exceptions
{
    public sealed class InvalidDateTimeException : Exception
    {
        public InvalidDateTimeException()  { }
        public InvalidDateTimeException(string msg) : base(msg) { }
        public InvalidDateTimeException(string msg, Exception ex) : base(msg, ex) { }
    }
}
