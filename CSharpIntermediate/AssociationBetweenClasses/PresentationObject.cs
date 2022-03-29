using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpIntermediate.AssociationBetweenClasses
{
    

    public class PresentationObject
    {
        public int Width { get; set; }  
        public int Height { get; set; }


        public void Copy()
        {
            Console.WriteLine("Object copy to clipboard.");
        }

        public void Duplicate()
        {
            Console.WriteLine("Object was duplicated");

        }
    }
}
