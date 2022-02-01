using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Web.Services;
using Web.ViewModels;

namespace Web.Controllers
{
    public class DisplayController : Controller
    {
        private readonly IExtractGivenNameRawToObjectService _extractGivenNameService;
        private readonly ISortNameService _sortNameService;
        private readonly ICreateAndWriteFileService _writeFileService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public DisplayController(IWebHostEnvironment webHostEnvironment,ICreateAndWriteFileService writeFileService,IExtractGivenNameRawToObjectService extractGivenNameService, ISortNameService sortNameService)
        {
            _extractGivenNameService = extractGivenNameService;
            _sortNameService = sortNameService;
            _writeFileService = writeFileService;
            _webHostEnvironment = webHostEnvironment;

        }
        public IActionResult Index(string filename)
        {
            var beforelongString = _extractGivenNameService.ExtractFileToStringResult(filename);
            var peopleName = _extractGivenNameService.ExtractFileToObjectResult(filename);
            var objSorted = _sortNameService.SortAll(peopleName);
            var afterlongString = _extractGivenNameService.ExtractFileToStringResult(objSorted);
            _writeFileService.WriteFile(afterlongString,filename);
            var viewmodel = new SorterNameViewModel() { FullNameAfterSort = afterlongString.TrimEnd(), FullNameBeforeSort = beforelongString };
            //Fetch all files in the Folder (Directory).
            string[] filePaths = Directory.GetFiles(Path.Combine(this._webHostEnvironment.WebRootPath, "sortedFiles/"));
            
            //Copy File names to Model collection.
            List<FileViewModel> files = new List<FileViewModel>();
            foreach (string filePath in filePaths)
            {
                files.Add(new FileViewModel { FileName = Path.GetFileName(filePath) });
            }

           
            viewmodel.FileViewModelList = new List<FileViewModel>();
            viewmodel.FileViewModelList.AddRange(files);
            return View(viewmodel);
        }
        public FileResult DownloadFile(string fileName)
        {
            //Build the File Path.
            string path = Path.Combine(this._webHostEnvironment.WebRootPath, "sortedFiles/") + fileName;

            //Read the File data into Byte Array.
            byte[] bytes = System.IO.File.ReadAllBytes(path);

            //Send the File to Download.
            return File(bytes, "application/octet-stream", fileName);
        }
    }
}
