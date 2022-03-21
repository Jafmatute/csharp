using System;
using System.IO;

namespace csharpFundamentals.Class.Files
{
    class DirectoryDirectoryInfo
    {

        public void Directory_()
        {
            Directory.CreateDirectory(@"c:\temp\folder1");

            var files = Directory.GetFiles(@"c:\projects\CSharpFundamentals", "*.sln*", SearchOption.AllDirectories);

            foreach (var file in files) Console.WriteLine(file);

            var directories = Directory.GetDirectories(@"c:\projects\CSharpFundamentals","*.*",SearchOption.AllDirectories);

            foreach (var directory in directories) Console.WriteLine(directory);

            if (Directory.Exists(@"c:\projects\CSharpFundamentals"))
            {
                //logic
            }
            
        }

        public void DirectoryInfo_()
        {
            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();



        }
    }
}
