using Database_workshop;
using System;

namespace DatabaseWorkshop 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Context())
            {

                var cst = new Customer()
                {
                    Name = "Alice",
                    Email = "Alice@mail.com",
                    Phone = "0717171171",
                    Address = "Wonderland"
                };

                context.Customers.Add(cst);
                context.SaveChanges();
            }
        }
    }
}
