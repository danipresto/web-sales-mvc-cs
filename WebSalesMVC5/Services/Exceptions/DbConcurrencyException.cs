using System;

namespace WebSalesMVC5.Services.Exceptions
{
    public class DbConcurrencyException : ApplicationException
    {
        public DbConcurrencyException (string message):base(message)
        {

        }
    }
}
