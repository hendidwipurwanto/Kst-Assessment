using BAL.Services;
using DTO.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Unit_Test
{
    [TestClass]
    public class SorterNameServiceTest
    {
        private readonly ISortNameService _sortNameService;
        public SorterNameServiceTest()
        {
            var services = new ServiceCollection();
            services.AddTransient<ISortNameService, SortNameService>();

            var serviceProvider = services.BuildServiceProvider();

            _sortNameService = serviceProvider.GetService<ISortNameService>();
        }

        [TestMethod]
        public void Given_several_Unsorted_Name_should_Return_Sorted_Name()
        {

            var _person1 = new Person() { FirstName = "norick", LastName = "Abe" };
            var _person2 = new Person() { FirstName = "Ratu", LastName = "Bunga" };
            var _person3 = new Person() { FirstName = "Ratu", LastName = "Cantika" };


            List<Person> people = new List<Person>();
            List<Person> expectedpeople = new List<Person>();
            expectedpeople.Add(_person1);
            expectedpeople.Add(_person2);
            expectedpeople.Add(_person3);
            people.Add(_person3);
            people.Add(_person2);
            people.Add(_person1);
            var result = _sortNameService.SortAll(people);
            for (int i = 0; i < expectedpeople.Count ; i++)
            {
                for (int j = 0; j <result.Count; j++)
                {
                    Assert.AreEqual(expectedpeople[j].FirstName, result[j].FirstName);
                    Assert.AreEqual(expectedpeople[j].SecondName, result[j].SecondName);
                    Assert.AreEqual(expectedpeople[j].ThirdName, result[j].ThirdName);
                    Assert.AreEqual(expectedpeople[j].FourthName, result[j].FourthName);
                    Assert.AreEqual(expectedpeople[j].FifthName, result[j].FifthName);
                    Assert.AreEqual(expectedpeople[j].SixthName, result[j].SixthName);
                    Assert.AreEqual(expectedpeople[j].SeventhName, result[j].SeventhName);
                    Assert.AreEqual(expectedpeople[j].EighthName, result[j].EighthName);
                    Assert.AreEqual(expectedpeople[j].NinthName, result[j].NinthName);
                    Assert.AreEqual(expectedpeople[j].TenthName, result[j].TenthName);
                    Assert.AreEqual(expectedpeople[j].LastName, result[j].LastName);

                }

            }
            
           
        }
    }
}
