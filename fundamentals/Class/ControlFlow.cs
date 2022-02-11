using System;
using System.Collections.Generic;
using System.Text;

namespace csharpFundamentals.Class
{

    public class ControlFlow
{
        public void Sentences()
        {
            int hours = 13;
            if (hours > 0 && hours < 12)
            {
                Console.WriteLine("It's morning ");
            }
            else if(hours>=12 && hours <18)
            {
                Console.WriteLine("It's afternoon");
            }
            else
            {
                Console.WriteLine("it's evening.");
            }

            //example two
            bool isGodCustomer = true;
            float price;

            if (isGodCustomer)
                price = 19.95f;
            else
                price = 29.95f;

            //ternary recommended use
            float price2 = (isGodCustomer) ? 19.95f : 29.95f;

            Console.WriteLine(string.Format("{0} {1}", price, price2));

            var season = Season.Autumn;

            switch (season)
            {
                //execute two case 
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("we've got promotions");
                    break;

                case Season.Sprint:
                    Console.WriteLine("its morning at 8 am is at perfect run");
                    break;
                /*case Season.Summer:
                    Console.WriteLine("It's perfect to go to beach");

                    break;
                case Season.Autumn:
                    Console.WriteLine("It's autom a beautiful seasion");
                    break;*/
                case Season.Winter:
                    Console.WriteLine("Prints in winter season");

                    break;
                default:
                    Console.WriteLine("It's don't understand that season!");
                    break;
            }
        }

}
}
