using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Services
{
    public class SorterNameFileService:ISorterNameFileService
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        public SorterNameFileService(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public void DeleteAllFile()
        {
            string path = Path.Combine(_webHostEnvironment.WebRootPath, "sortedFiles");
            System.IO.DirectoryInfo di = new DirectoryInfo(path);

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
        
        }

        public string UploadFile(IFormFile file)
        {
            if (file == null)
                return string.Empty;

            string _fileName = null;
            try
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "UnsortedFiles");
                _fileName = Path.GetExtension(file.FileName);
                string filePath = Path.Combine(uploadsFolder, file.FileName);
                file.CopyTo(new FileStream(filePath, FileMode.Create));
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return file.FileName;
        }
    }
}
