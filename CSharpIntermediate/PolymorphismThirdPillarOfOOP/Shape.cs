using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpIntermediate.PolymorphismThirdPillarOfOOP
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        private Position Position { get; set; }
        //public ShapeType Type { get; set; }

        // public virtual void Draw()
        // {
        //
        // }

        public abstract void Draw();

        public void Copy()
        {
            Console.WriteLine("Copy to clipboard.");
        }

        public void Select()
        {
            Console.WriteLine("Select the shape");
        }
    }
}
