using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Existek_Lesson1_1.Interfaces
{
    public class ServiceHelper
    {
        private List<CloudService> _services;
        public ServiceHelper()
        {
            _services = new List<CloudService>();
        }

        public void AddService(CloudService cloudService)
        {
            if (cloudService.Connect())
            {
                _services.Add(cloudService);
            }
        }

        public void Upload(string file)
        {
            _services.ForEach(s => s.UploadData(file));
        }

        public void Download(string file)
        {
            _services.ForEach(s => Console.WriteLine(s.DownloadData(file)));
        }
    }
}
