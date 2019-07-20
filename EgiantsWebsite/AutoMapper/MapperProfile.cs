using AutoMapper;
using EgiantsService;
using EgiantsWebsite.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EgiantsWebsite.AutoMapper
{
    public class MapperProfile : Profile
    {
        //Create mapping from viewModel to Dto
        public MapperProfile()
        {
            CreateMap<ContactViewModel, ContactDto>().ReverseMap();
        }
    }
}