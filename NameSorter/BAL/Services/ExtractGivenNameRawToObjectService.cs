using DAL.Repositories;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Services
{
    public class ExtractGivenNameRawToObjectService : IExtractGivenNameRawToObjectService
    {
        private readonly IDataRepository _dataRepository;
        private readonly IMapperGivenNameService _mapperWithGivenNameService;
        public ExtractGivenNameRawToObjectService(IMapperGivenNameService mapperWithGivenNameService, IDataRepository dataRepository)
        {
            _mapperWithGivenNameService = mapperWithGivenNameService;
            _dataRepository = dataRepository;
        }
        public List<Person> ExtractFileToObjectResult(string fileName)
        {
            var result = new List<Person>();
            var rawText = _dataRepository.ReadFile(fileName);
            var separatorText = rawText.Replace(System.Environment.NewLine, "|");
            var arrOfFullName = separatorText.Split("|");

            for (int i = 0; i < arrOfFullName.Length; i++)
            {
                var temp = new Person();
                var arr = arrOfFullName[i].Split(" ");
                int givenNameCount = arr.Length;
                string fullName = arrOfFullName[i];
                switch (givenNameCount)
                {
                    case 1:
                        temp = _mapperWithGivenNameService.Map1GivenName(fullName);
                        result.Add(temp);
                        break;
                    case 2:
                        temp = _mapperWithGivenNameService.Map2GivenName(fullName);
                        result.Add(temp);
                        break;
                    case 3:
                        temp = _mapperWithGivenNameService.Map3GivenName(fullName);
                        result.Add(temp);
                        break;
                    case 4:
                        temp = _mapperWithGivenNameService.Map4GivenName(fullName);
                        result.Add(temp);
                        break;
                    case 5:
                        temp = _mapperWithGivenNameService.Map5GivenName(fullName);
                        result.Add(temp);
                        break;
                }






            }
            return result;
        }

        public string ExtractFileToStringResult(string fileName)
        {
            var people = new List<Person>();
            var result = string.Empty;
            var rawText = _dataRepository.ReadFile(fileName);
            return rawText;
        }

        public string ExtractFileToStringResult(List<Person> people)
        {
            string fullname = string.Empty;
            string allnames = string.Empty;
            for (int i = 0; i < people.Count; i++)
            {
                fullname = people[i].FirstName + " " + people[i].SecondName + "" + people[i].ThirdName + "" + people[i].FourthName + "" + people[i].FifthName + "" + people[i].SixthName + " " + people[i].SeventhName + "" + people[i].EighthName + "" + people[i].NinthName + "" + people[i].TenthName + " " + people[i].LastName;

                allnames = allnames + "\r\n" + fullname;


            }
            return allnames;
        }
    }
}
