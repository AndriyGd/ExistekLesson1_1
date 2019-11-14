using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Existek_Lesson1_1.Interfaces
{
    public abstract class CloudService
    {
        public string Url { get; }

        protected CloudService(string url)
        {
            Url = url;
        }

        public bool Connect()
        {
            //TODO connect to cloud storage
            Console.WriteLine($"Service was connected by Url: {Url}");

            return true;
        }

        public abstract void UploadData(string file);
        public abstract string DownloadData(string file);
    }
}
