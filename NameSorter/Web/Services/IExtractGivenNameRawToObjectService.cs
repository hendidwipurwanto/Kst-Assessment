﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Services
{
    public interface IExtractGivenNameRawToObjectService
    {
        public List<Person> ExtractFileToObjectResult(string fileName);
        public string ExtractFileToStringResult(string fileName);
        public string ExtractFileToStringResult(List<Person> people);

    }
}
