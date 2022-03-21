using System;
using System.Collections.Generic;
using System.Text;

namespace csharpFundamentals.Class.Files
{
    class Path
    {
        public void Path_()
        {
            var path = @"C:\Users\josue\source\repos\CSharpFundamentals\csharpFundamentals.sln";

            var dotIndex = path.IndexOf('.');

            var extension = path.Substring(dotIndex);

            Console.WriteLine("Extension " + System.IO.Path.GetExtension(path));
            Console.WriteLine("File Name " + System.IO.Path.GetFileName(path));
            Console.WriteLine("File Name without Extension " + System.IO.Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name " + System.IO.Path.GetDirectoryName(path));

        }
    }
}
