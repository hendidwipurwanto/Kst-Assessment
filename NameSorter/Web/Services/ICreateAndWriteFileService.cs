using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Services
{
    public interface ICreateAndWriteFileService
    {
        void WriteFile(string sortedTextList, string unsortedFileName);
    }
}
