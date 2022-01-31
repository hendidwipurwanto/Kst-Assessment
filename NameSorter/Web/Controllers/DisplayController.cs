using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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
        public DisplayController(IExtractGivenNameRawToObjectService extractGivenNameService, ISortNameService sortNameService)
        {
            _extractGivenNameService = extractGivenNameService;
            _sortNameService = sortNameService;

        }
        public IActionResult Index(string filename)
        {
            var beforelongString = _extractGivenNameService.ExtractFileToStringResult(filename);
            var peopleName = _extractGivenNameService.ExtractFileToObjectResult(filename);
            var objSorted = _sortNameService.SortAll(peopleName);
            var afterlongString = _extractGivenNameService.ExtractFileToStringResult(objSorted);

            var viewmodel = new SorterNameViewModel() { FullNameAfterSort = afterlongString.TrimEnd(), FullNameBeforeSort = beforelongString };

            return View(viewmodel);
        }
    }
}
