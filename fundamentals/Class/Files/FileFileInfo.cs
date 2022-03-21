using System.IO;

namespace csharpFundamentals.Class.Files
{
    class FileFileInfo
    {

        public void File_()
        {
            var path = @"c:\somefile.jpg";

            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
            File.Delete(path);

            if (File.Exists(path))
            {
                //logic

            }

            var content = File.ReadAllText(path);


        }

        public void FileInfo_()
        {
            var path = @"c:\somefile.jpg";

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();

            if (fileInfo.Exists)
            {
                //logic
            }




        }
    }
}
