using BAL.Services;
using DTO.ViewModels;
using DTO.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISorterNameFileService _sorterNameFileService;
        private readonly IExtractGivenNameRawToObjectService _extractGivenNameService;
        private readonly ILogger<HomeController> _logger;
        private readonly IMapperGivenNameService _mapperrWith1GivenNameService;
        private readonly ISortNameService _sortNameService;

        public HomeController(IMapperGivenNameService mapperrWith1GivenNameService,ISortNameService sortNameService,IExtractGivenNameRawToObjectService extractGivenNameService,ISorterNameFileService sorterNameFileService, ILogger<HomeController> logger)
        {
            _mapperrWith1GivenNameService = mapperrWith1GivenNameService;
            _extractGivenNameService = extractGivenNameService;
            _sorterNameFileService = sorterNameFileService;
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
            if (ModelState.IsValid)
            {
                try
                {
                    _sorterNameFileService.DeleteAllFile();
                    var fileName = _sorterNameFileService.UploadFile(viewModel.TextFile);
                    var peopleName = _extractGivenNameService.ExtractFileToStringResult(fileName);

                    return RedirectToAction("Index", "Display", new { fileName = fileName });

                }
                catch (Exception ex)
                {
                   
                    throw ex;
                }
               
            }
            var errors = ModelState.Values.SelectMany(v => v.Errors);
            return View(viewModel);



            

        }
        
    }
}
