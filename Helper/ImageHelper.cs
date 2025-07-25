using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSpresso.Helper
{
    public class ImageHelper
    {
        public static string SaveUserImage(string sourcePath)
        {
            string fileName = Path.GetFileName(sourcePath);
            string destinationFolder = Path.Combine(Application.StartupPath, "Assets", "Images", "Users");
            Directory.CreateDirectory(destinationFolder); 
            string destinationPath = Path.Combine(destinationFolder, fileName);

            File.Copy(sourcePath, destinationPath, true); // Overwrite if exists

            return Path.Combine("Assets", "Images", "Users", fileName); // Return path
        }
    }
}
