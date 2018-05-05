using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AnPCutting.MVC.Models
{
    public static class FileChecks {

        public static bool IsImage(this string fileName)
        {
            var imageFileExtensions = new string[] { ".png", ".jpg", ".jpeg" };

            foreach (var ext in imageFileExtensions)
            {
                if (fileName.EndsWith(ext)) { return true; }
            }

            return false;
        }
    }

    public class AnPImageList
    {
        // May want to use a database.
        private IEnumerable<string> imageList;

        public AnPImageList()
        {
            imageList = new List<string>();
        }
        
        public void AddImage(string file)
        {
            if (file.IsImage())
            {
                // Want to make sure that only the appropriate substring for the filename is selected.

                // Also want to make sure that a the image is not already stored.

                // Also, add image to Images/Photos folder.
                imageList.Append(file);
            }
        }

        
    }
}
