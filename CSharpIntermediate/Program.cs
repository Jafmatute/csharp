using System;
using System.Data;
using CSharpIntermediate.Classes;

namespace CSharpIntermediate
{

    
    class Program
    {
        static void Main()
        {
         
          var customer = new Customer();
          customer.Id = 1;
          customer.Name = "Josue";

          var order = new Order();
          customer.Orders.Add(order);
          Console.WriteLine(customer.Id);
          Console.WriteLine(customer.Name);
        }
    }
}
