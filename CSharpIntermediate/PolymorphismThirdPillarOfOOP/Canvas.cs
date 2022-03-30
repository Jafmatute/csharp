using System;
using System.Collections.Generic;

namespace CSharpIntermediate.PolymorphismThirdPillarOfOOP
{
    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();

                // Bad practice
                /*switch (shape.Type)
                {
                    case ShapeType.Circle:
                        Console.WriteLine("Draw a circle");
                        break;

                    case ShapeType.Rectangle:
                        Console.WriteLine("Draw a rectangle");
                        break;

                    case ShapeType.Triangle:
                        Console.WriteLine("Draw a triangle");
                        break;
                }*/
            }
        }
    }
}