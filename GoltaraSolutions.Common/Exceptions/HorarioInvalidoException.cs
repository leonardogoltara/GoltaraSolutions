using System;
namespace GoltaraSolutions.Common.Exceptions
{
    public class HorarioInvalidoException : Exception
    {
        public HorarioInvalidoException(string message) : base(message)
        { }
        public HorarioInvalidoException(string message, Exception innerException) : base(message, innerException)
        { }
    }
}
