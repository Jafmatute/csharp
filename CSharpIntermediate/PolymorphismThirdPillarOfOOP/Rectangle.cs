﻿using System;

namespace CSharpIntermediate.PolymorphismThirdPillarOfOOP
{
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            //base.Draw();

            Console.WriteLine("Draw a rectangle");
        }
    }
}