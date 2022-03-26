using System;
using CSharpIntermediate.Classes;

namespace CSharpIntermediate
{

    
    class Program
    {
        static void Main()
        {
         
           var person = Person.Parse("Josue");
           person.Introduce("Flores");
        }
    }
}
