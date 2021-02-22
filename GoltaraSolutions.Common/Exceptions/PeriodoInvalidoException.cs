using System;
namespace GoltaraSolutions.Common.Exceptions
{
    public class PeriodoInvalidoException : Exception
    {
        public PeriodoInvalidoException(string message) : base(message)
        { }
        public PeriodoInvalidoException(string message, Exception innerException) : base(message, innerException)
        { }
    }
}
