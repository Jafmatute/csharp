using System;

namespace CSharpIntermediate.PolymorphismThirdPillarOfOOP
{
    public class Triangle : Shape
    {
        public override void Draw()
        {
            // base.Draw();
            Console.WriteLine("Draw a Triangle");
        }
    }
}