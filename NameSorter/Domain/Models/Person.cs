using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string FourthName { get; set; }
        public string FifthName { get; set; }
        public string SixthName { get; set; }
        public string SeventhName { get; set; }
        public string EighthName { get; set; }

        public string NinthName { get; set; }
        public string TenthName { get; set; }

        public string LastName { get; set; }

        // this overriden for unit test purpose only
        public override bool Equals(Object obj)
        {
            if (obj is Person)
            {
                var that = obj as Person;
                return this.FirstName == that.FirstName && this.SecondName == that.SecondName && this.ThirdName == that.ThirdName && this.FourthName== that.FourthName && this.FifthName == that.FifthName && this.SixthName== that.SixthName && this.SeventhName == that.SeventhName && this.NinthName== that.NinthName && this.TenthName== that.NinthName && this.LastName== that.LastName;
            }

            return false;
        }
    }
}
