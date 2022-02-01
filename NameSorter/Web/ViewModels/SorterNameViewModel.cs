using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewModels
{
    public class SorterNameViewModel
    {
       
        public IFormFile TextFile { get; set; }
        public string FullNameBeforeSort { get; set; }
        public string FullNameAfterSort { get; set; }

        public List<FileViewModel> FileViewModelList { get; set; }
    }
}
