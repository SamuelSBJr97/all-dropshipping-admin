using System;

namespace DropshippingAdmin.Core.Shared.Exceptions
{
    public class DomainException : Exception
    {
        public DomainException(string message) : base(message) { }
    }
}
