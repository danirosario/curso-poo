using System;

namespace ExTratamentoExcecoes.Entities.Exceptions
{
    internal class DomainException : ApplicationException
    {
        public DomainException() { }

        public DomainException(string message) : base(message) { }

        public DomainException(string message, Exception innerException) : base(message, innerException) { }
    }
}
