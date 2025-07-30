using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSpresso.Helper
{
    public class ImageHelper
    {
       /* public static string SaveImage(string sourcePath, string categoryFolder)
        {
            string fileName = Path.GetFileName(sourcePath);
            string destinationFolder = Path.Combine(Application.StartupPath, "Assets", "Images", categoryFolder);
            string destinationPath = Path.Combine(destinationFolder, fileName);

            Directory.CreateDirectory(destinationFolder); // ensure folder exists

            try
            {
                File.Copy(sourcePath, destinationPath, true); // Overwrite if exists
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to copy file:\n{ex.Message}");
            }

            return Path.Combine("Assets", "Images", categoryFolder, fileName); // relative path for DB
        }*/
        

        public static Image? LoadImage(string? relativePath, string? fallbackPath = null)
        {
            if (string.IsNullOrWhiteSpace(relativePath))
                return fallbackPath != null ? LoadImage(fallbackPath) : null;

            try
            {
                string fullPath = Path.Combine(Application.StartupPath, relativePath);
                using var fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read);
                return Image.FromStream(fs);
            }
            catch
            {
                return fallbackPath != null ? LoadImage(fallbackPath) : null;
            }
        }
    }
}

