using System;
namespace GoltaraSolutions.Common.Exceptions
{
    public class DiasSemanaInvalidoException : Exception
    {
        public DiasSemanaInvalidoException(string message) : base(message)
        { }
        public DiasSemanaInvalidoException(string message, Exception innerException) : base(message, innerException)
        { }
    }
}
