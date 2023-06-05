using System;

namespace ConsoleApp1.Entities.Exceptions
{
	class DomainException : ApplicationException
	{
		public DomainException(string message) : base(message)
		{
		}
	}
}