using System;

namespace CSharpIntermediate.InheritanceSecondPillarOfOOP

{
    class Card : Vehicle
    {
        public Card(string registrationNumber):base(registrationNumber)
        {
            Console.WriteLine("Car is being initialized, {0}", registrationNumber);
        }
    }
}