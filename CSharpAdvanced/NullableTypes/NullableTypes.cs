using System;

namespace CSharpAdvanced.NullableTypes
{
    public class NullableTypes
    {

        public void Main()
        {
            //Nullable
            DateTime? date = null;
            Console.WriteLine("GetValueOrDefault(): " + date.GetValueOrDefault());
            Console.WriteLine("HasValue: " + date.HasValue);
            //Console.WriteLine("Value " + date.Value);

            Console.WriteLine("-------------------------------");

            DateTime? dateTime = new DateTime(2022, 4, 11);
            DateTime dateTime2 = dateTime.GetValueOrDefault();
            DateTime? dateTime3 = dateTime2;
            Console.WriteLine(dateTime2);
            Console.WriteLine(dateTime3);

            Console.WriteLine("-------------------Null Coalescing Operator--------------");
            //  Null Coalescing Operator
            DateTime? dateNull = null;
            DateTime dateNull2 = date ?? DateTime.Today;

            //DateTime dateNull2;
            //if (dateNull != null) dateNull2 = dateNull.GetValueOrDefault();
            //else dateNull2 = DateTime.Today;

            Console.WriteLine(dateNull2);



        }

    }
}
