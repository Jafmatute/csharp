using System;


namespace csharpFundamentals.Class.Exercises
{

    public class CSharp1Exercises
    {
        public void Exercise1()
        {
            Console.WriteLine("Enter a number between 1 a 10");
            var inputNumber = Console.ReadLine();
            int spaceNumber = Convert.ToInt32(inputNumber);
            if((spaceNumber >0) && (spaceNumber <= 10))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            
        }

        public void Exercise2()
        {
            Console.WriteLine("Enter number one");
            var input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number two");
            var input2 = Convert.ToInt32(Console.ReadLine());

            int max = (input1 > input2) ? input1 : input2;
            Console.WriteLine(string.Format("value max is:{0}", max));
            



        }

        public void Exercise3()
        {
            Console.WriteLine("Enter image Width");
            var width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Image Height enter");
            var height = Convert.ToInt32(Console.ReadLine());

            var orientation = width > height ? ImageOrientation.Landscape : ImageOrientation.Portrait;

            Console.WriteLine("Image orientation is " + orientation);
        }

        public void Exercise4()
        {
            Console.WriteLine("what is the speed limit");
            var speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the speed of this car?");
            var cardSpeed = Convert.ToInt32(Console.ReadLine());
            if(cardSpeed > speedLimit)
            {
                Console.WriteLine("OK");
            }
            else
            {
                const int kmPerDemeritPoint = 5;
                var demeritPoints = (cardSpeed - speedLimit) / kmPerDemeritPoint;
                if(demeritPoints > 12)
                {
                    Console.WriteLine("License Suspended");
                }
                else
                {
                    Console.WriteLine("Demerit points: " + demeritPoints);
                }

            }
        }

    }
}
