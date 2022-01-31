using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;
using Web.Services;
using Web.ViewModels;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUploadFileService _uploadFileService;
        private readonly IExtractGivenNameRawToObjectService _extractGivenNameService;
        private readonly ILogger<HomeController> _logger;
        private readonly IMapperGivenNameService _mapperrWith1GivenNameService;
        private readonly ISortNameService _sortNameService;

        public HomeController(IMapperGivenNameService mapperrWith1GivenNameService,ISortNameService sortNameService,IExtractGivenNameRawToObjectService extractGivenNameService,IUploadFileService uploadFileService, ILogger<HomeController> logger)
        {
            _mapperrWith1GivenNameService = mapperrWith1GivenNameService;
            _extractGivenNameService = extractGivenNameService;
            _uploadFileService = uploadFileService;
            _logger = logger;
            _sortNameService = sortNameService;
        }

        public IActionResult Index()
        {
            var viewModel = new SorterNameViewModel();
            return View(viewModel);
        }
        public IActionResult Upload()
        {
            var viewModel = new SorterNameViewModel();
            return PartialView("Upload", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Process(SorterNameViewModel viewModel)
        {
            var fileName = _uploadFileService.UploadFile(viewModel.TextFile);
            //var people = _extractGivenNameService.ExtractFileToStringResult(fileName);


            //var afterSort = _sortNameService.SortAll(people);
           

            return RedirectToAction("Index", "Display", new { fileName = fileName });

        }
        
    }
}
