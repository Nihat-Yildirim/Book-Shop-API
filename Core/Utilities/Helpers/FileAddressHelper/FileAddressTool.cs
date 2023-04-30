using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Helpers.FileAddressHelper
{
    public static class FileAddressTool
    {
        public static string CreateFileAddress(string filePath)
        {
            int index = filePath.IndexOf("Uploads");
            string newPath = filePath.Remove(0, index);
            string url = "http://localhost:5214/" + newPath;
            
            return url;
        }
    }
}
