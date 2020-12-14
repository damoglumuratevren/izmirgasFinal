using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using IzmirGaz.Entities.Concrete;
using IzmirGaz.Entities.Dtos;

namespace IzmirGas.Services.AutoMapper.Profiles
{
    public class CompanyProfile:Profile
    {
        public CompanyProfile()
        {
            CreateMap<CampanyAddDto, Company>()
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(c => DateTime.Now));
            CreateMap<CompanyUpdateDto, Company>()
                .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(c => DateTime.Now));

        }
    }
}
