using BAL.Services;
using DTO.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Unit_Test
{
    [TestClass]
    public class MapperGivenNameServiceTest
    {
        private readonly IMapperGivenNameService _mapperGivenNameService;

        public MapperGivenNameServiceTest()
        {
            var services = new ServiceCollection();
            services.AddTransient<IMapperGivenNameService, MapperGivenNameService>();

            var serviceProvider = services.BuildServiceProvider();

            _mapperGivenNameService = serviceProvider.GetService<IMapperGivenNameService>();
        }

        [TestMethod]
        public void Given_set_of_One_GivenName_should_Return_in_an_Object_of_Person()
        {
            //Arrange
            string OneGivenName = "Michelle Branch";
            var expectedResult = new Person() { FirstName = "Michelle", SecondName= string.Empty, LastName = "Branch" };

            // Act
            var Obj_actualResult = _mapperGivenNameService.Map1GivenName(OneGivenName);

            // Assert
            Assert.AreEqual(expectedResult, Obj_actualResult);
           


        }
        [TestMethod]
        public void Given_set_of_two_GivenName_should_Return_in_an_Object_of_Person()
        {
            string twoGivenName = "Hailey Avie Annakin";
            var expectedResult = new Person() { FirstName = "Hailey", SecondName = "Avie", LastName = "Annakin" };

            // Act
            var Obj_actualResult = _mapperGivenNameService.Map2GivenName(twoGivenName);

            // Assert
            Assert.AreEqual(expectedResult, Obj_actualResult);



        }
        [TestMethod]
        public void Given_set_of_three_GivenName_should_Return_in_an_Object_of_Person()
        {

            string threeGivenName = "Leonerd Adda Mitchell Monaghan";
            var expectedResult = new Person() { FirstName = "Leonerd", SecondName = "Adda", ThirdName= "Mitchell", LastName = "Monaghan" };

            // Act
            var Obj_actualResult = _mapperGivenNameService.Map3GivenName(threeGivenName);

            // Assert
            Assert.AreEqual(expectedResult, Obj_actualResult);



        }

        [TestMethod]
        public void Given_set_of_Four_GivenName_should_Return_in_an_Object_of_Person()
        {

            string FourGivenName = "uzumaki Leonerd Adda Mitchell Monaghan";
            var expectedResult = new Person() { FirstName = "uzumaki", SecondName = "Leonerd", ThirdName = "Adda", FourthName = "Mitchell", LastName = "Monaghan" };

            // Act
            var Obj_actualResult = _mapperGivenNameService.Map4GivenName(FourGivenName);

            // Assert
            Assert.AreEqual(expectedResult, Obj_actualResult);



        }
        [TestMethod]
        public void Given_set_of_Five_GivenName_should_Return_in_an_Object_of_Person()
        {

            string FiveGivenName = "uzumaki Leonerd Adda Mitchell Andry Monaghan";
            var expectedResult = new Person() { FirstName = "uzumaki", SecondName = "Leonerd", ThirdName = "Adda", FourthName = "Mitchell", FifthName= "Andry", LastName = "Monaghan" };

            // Act
            var Obj_actualResult = _mapperGivenNameService.Map5GivenName(FiveGivenName);

            // Assert
            Assert.AreEqual(expectedResult, Obj_actualResult);



        }
    }
}
