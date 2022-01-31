using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Services
{
    public class SortNameService : ISortNameService
    {
        public List<Person> SortAll(List<Person> peopleName)
        {
            return peopleName.OrderBy(o => o.LastName).ThenBy(o => o.TenthName).ThenBy(o => o.NinthName).ThenBy(o => o.EighthName)
                .ThenBy(o => o.SeventhName).ThenBy(o => o.SixthName).ThenBy(o => o.FifthName).ThenBy(o => o.FourthName)
                .ThenBy(o => o.ThirdName).ThenBy(o => o.SecondName).ThenBy(o => o.FirstName).ToList();
        }
    }
}
