using System;

namespace CSharpIntermediate.PolymorphismThirdPillarOfOOP
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            // any code specific to the circle itself
            //base.Draw();

            Console.WriteLine("Draw a circle");
        }
    }
}