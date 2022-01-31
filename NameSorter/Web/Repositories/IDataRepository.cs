using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Repositories
{
    public interface IDataRepository
    {
        public string ReadFile(string fileName);
    }
}
