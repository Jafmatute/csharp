using System;
using System.Text;

namespace csharpFundamentals.Class.Text
{
    class StringBuilderText
    {

        public void Builder()
        {
            var builder = new StringBuilder("Hello World");

            /*builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);
            
             builder.Replace('-', '+');
            builder.Remove(0, 10);
            builder.Insert(0, new string('-', 10));
             
             */

            // code clear
            builder.Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
                .Remove(0, 10)
                .Insert(0, new string('-', 10));

            Console.WriteLine(builder);

            Console.WriteLine("First char: " + builder[0]);
        }
    }
}
