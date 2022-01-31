using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Services
{
    public class UploadFileService:IUploadFileService
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        public UploadFileService(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
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
