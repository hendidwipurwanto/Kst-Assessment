using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class SorterName
    {
        public int Id { get; set; }
        public string TextFile { get; set; }
        public string FullNameBeforeSort { get; set; }
        public string FullNameAfterSort { get; set; }
    }
}
