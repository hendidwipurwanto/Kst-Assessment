using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ViewModels
{
    public class SorterNameViewModel
    {
        [Required]
        public IFormFile TextFile { get; set; }
        public string FullNameBeforeSort { get; set; }
        public string FullNameAfterSort { get; set; }

        public List<FileViewModel> FileViewModelList { get; set; }
    }
}
