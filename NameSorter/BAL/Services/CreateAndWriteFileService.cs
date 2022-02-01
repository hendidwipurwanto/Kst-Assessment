using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Services
{
    public class CreateAndWriteFileService:ICreateAndWriteFileService
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        public CreateAndWriteFileService(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public void WriteFile(string sortedTextList, string unsortedFileName)
        {

            string filename = unsortedFileName.Split(".txt")[0];
            string path = Path.Combine(_webHostEnvironment.WebRootPath, "sortedFiles") + "\\" + filename + "-" + "[has_sorted].txt";
            if (!System.IO.File.Exists(path))
            {
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers();

                System.IO.File.WriteAllText(path, sortedTextList);



            }

        }

    }
}
