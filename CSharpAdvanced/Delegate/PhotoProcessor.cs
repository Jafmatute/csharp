using System;

namespace CSharpAdvanced.Delegate
{
    public class PhotoProcessor
    {
        //public void Processor(string path)
        //{
        //    var photo = Photo.Load(path);

        //    var filters = new PhotoFilters();
        //    filters.ApplyBrightness(photo);
        //    filters.ApplyContrast(photo);
        //    filters.Resize(photo);

        //    photo.Save();
        //}


        //System.Action<> return void
        //System.Func<> return value

        //public delegate void PhotoFilterHandler(Photo photo);



        public void Processor(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);
            filterHandler(photo);
            photo.Save();
        }

    }
}