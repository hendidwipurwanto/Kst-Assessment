using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Services
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
