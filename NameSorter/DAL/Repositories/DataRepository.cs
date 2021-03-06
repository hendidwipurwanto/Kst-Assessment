using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class DataRepository:IDataRepository
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        public DataRepository(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public string ReadFile(string fileName)
        {
            string rawText = string.Empty;
            string path = Path.Combine(_webHostEnvironment.WebRootPath, "UnsortedFiles") + "\\" + fileName;
            if (System.IO.File.Exists(path))
            {
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers();
                rawText = System.IO.File.ReadAllText(path);
            }

            return rawText;
        }
    }
}
