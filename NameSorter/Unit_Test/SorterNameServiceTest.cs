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
            //Arrange
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

            // Act
            var result = _sortNameService.SortAll(people);
           
                // Assert
                CollectionAssert.AreEqual(expectedpeople, result);
               

            
            
           
        }
    }
}
