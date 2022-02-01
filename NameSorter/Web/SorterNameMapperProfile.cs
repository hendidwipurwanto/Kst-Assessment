using AutoMapper;
using DTO.Models;
using DTO.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Web
{
    public class SorterNameMapperProfile:Profile
    {
        public SorterNameMapperProfile()
        {
            CreateMap<SorterName, SorterNameViewModel>().ReverseMap();
            CreateMap<SorterNameViewModel, SorterName>().ReverseMap();
        }
    }
}
