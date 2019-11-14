using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Existek_Lesson1_1.Interfaces
{
    public class OneDriveService : CloudService
    {
        public OneDriveService() : base("https://onedrive.live.com/about/uk-ua/")
        {
        }

        public override void UploadData(string file)
        {
            Console.WriteLine($"File {file} was uploaded to One Drive.");
        }

        public override string DownloadData(string file)
        {
            Console.WriteLine($"Downloading file {file} from One Drive...");
            return "When creating new applications or components, it is best to create .NET Framework.";
        }
    }
}
