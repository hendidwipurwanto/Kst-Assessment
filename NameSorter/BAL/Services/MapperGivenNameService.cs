using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Services
{
    public class MapperGivenNameService:IMapperGivenNameService
    {
        //public Person Map0GivenName(string fullName)
        //{
        //    var result = new Person();
        //    var arrFullName = fullName.Split(" ");
        //    int maxIdx = arrFullName.Length - 1;
        //    result.FirstName = arrFullName[0];
        //    result.SecondName = string.Empty;
        //    result.LastName = arrFullName[maxIdx];


        //    return result;
        //}
        public Person Map1GivenName(string fullName)
        { //example : uzumaki naruto
            var result = new Person();
            var arrFullName = fullName.Split(" ");
            int maxIdx = arrFullName.Length - 1;
            result.FirstName = arrFullName[0];
            result.SecondName = string.Empty;
            result.LastName = arrFullName[maxIdx];


            return result;

        }

        public Person Map2GivenName(string fullName)
        {
            //Hailey Avie Annakin
            var result = new Person();
            var arrFullName = fullName.Split(" ");
            int maxIdx = arrFullName.Length - 1;
            result.FirstName = arrFullName[0];
            result.SecondName = arrFullName[1];
            result.LastName = arrFullName[maxIdx];

            return result;
        }

        public Person Map3GivenName(string fullName)
        { // Leonerd Adda Mitchell Monaghan

            var result = new Person();
            var arrFullName = fullName.Split(" ");
            int maxIdx = arrFullName.Length - 1;
            result.FirstName = arrFullName[0];
            result.SecondName = arrFullName[1];
            result.ThirdName = arrFullName[2];
            result.LastName = arrFullName[maxIdx];

            return result;
        }

        public Person Map4GivenName(string fullName)
        { // uzumaki Leonerd Adda Mitchell Monaghan
            var result = new Person();
            var arrFullName = fullName.Split(" ");
            int maxIdx = arrFullName.Length - 1;
            result.FirstName = arrFullName[0];
            result.SecondName = arrFullName[1];
            result.ThirdName = arrFullName[2];
            result.FourthName = arrFullName[3];
            result.LastName = arrFullName[maxIdx];

            return result;
        }

        public Person Map5GivenName(string fullName)
        { // uzumaki Leonerd Adda Mitchell Andry Monaghan
            var result = new Person();
            var arrFullName = fullName.Split(" ");
            int maxIdx = arrFullName.Length - 1;
            result.FirstName = arrFullName[0];
            result.SecondName = arrFullName[1];
            result.ThirdName = arrFullName[2];
            result.FourthName = arrFullName[3];
            result.FifthName = arrFullName[4];
            result.LastName = arrFullName[maxIdx];

            return result;
        }

        public Person Map6GivenName(string fullName)
        { //  uzumaki Leonerd Adda Mitchell Andry peter Monaghan
            var result = new Person();
            var arrFullName = fullName.Split(" ");
            int maxIdx = arrFullName.Length - 1;
            result.FirstName = arrFullName[0];
            result.SecondName = arrFullName[1];
            result.ThirdName = arrFullName[2];
            result.FourthName = arrFullName[3];
            result.FifthName = arrFullName[4];
            result.SixthName = arrFullName[5];

            result.LastName = arrFullName[maxIdx];

            return result;
        }

    }
}
