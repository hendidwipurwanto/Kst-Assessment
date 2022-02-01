using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Services
{
    public interface ICreateAndWriteFileService
    {
        void WriteFile(string sortedTextList, string unsortedFileName);
    }
}
