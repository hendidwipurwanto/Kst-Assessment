using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;
using Web.ViewModels;

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
