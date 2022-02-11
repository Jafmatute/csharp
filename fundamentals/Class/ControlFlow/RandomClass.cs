using System;
using System.Collections.Generic;
using System.Text;

namespace csharpFundamentals.Class.ControlFlow
{
    class RandomClass
    {
        public void RandomValues()
        {
            /* var random = new Random();
             for (int i = 0; i <= 10; i++)
                 Console.WriteLine(random.Next(1,5));
                 Console.Write((char)random.Next(97, 122));
                Console.Write((char)('a'+random.Next(0, 26)));
            */

            //97-122 ANSCII -- 0 26 character inglish
            var random = new Random();
            const int passwordLength = 10;
            var buffer = new char[passwordLength];

            for (int i = 0; i < passwordLength; i++)
                buffer[i] = (char)('a' + random.Next(0, 26));

            var password = new string(buffer);

            Console.Write(password);
        }
    }
}
