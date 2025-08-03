using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSpresso.Helper
{
    public class ImageHelper
    {
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

