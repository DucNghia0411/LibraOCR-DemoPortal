using System.IO;

namespace WebOCR.Common
{
    public class Common
    {
        public static int CheckFileType(string fileName)
        {
            string ext = Path.GetExtension(fileName);
            switch (ext.ToLower())
            {
                case ".jpg":
                    return 1;
                case ".jpeg":
                    return 1;
                case ".png":
                    return 1;
                case ".pdf":
                    return 2;
                default:
                    return 0;
            }
        }
    }
}
