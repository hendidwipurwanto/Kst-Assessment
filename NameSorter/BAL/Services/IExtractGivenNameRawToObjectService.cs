using System.Collections.Generic;
using System;
using DTO.Models;

namespace BAL.Services
{
    public interface IExtractGivenNameRawToObjectService
    {
        public List<Person> ExtractFileToObjectResult(string fileName);
        public string ExtractFileToStringResult(string fileName);
        public string ExtractFileToStringResult(List<Person> people);
    }
}
