using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Models
{
    public class SorterName
    {
        public int Id { get; set; }
        public string TextFile { get; set; }
        public string FullNameBeforeSort { get; set; }
        public string FullNameAfterSort { get; set; }
    }
}
