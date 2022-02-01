using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Services
{
    public interface IMapperGivenNameService
    {
        public Person Map1GivenName(string fullName);
        public Person Map2GivenName(string fullName);
        public Person Map3GivenName(string fullName);
        public Person Map4GivenName(string fullName);
        public Person Map5GivenName(string fullName);
    }
}
