using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using IzmirGaz.Entities.Concrete;
using IzmirGaz.Entities.Dtos;

namespace IzmirGas.Services.AutoMapper.Profiles
{
     public class CompanyPersonnelProfile:Profile
    {
        public CompanyPersonnelProfile()
        {
            CreateMap<CompanyPersonnelAddDto, CompanyPersonnel>().ForMember(dest=>dest.CreatedDate,opt=>opt.MapFrom(x=>DateTime.Now));
            CreateMap<CompanyPersonnelUpdateDto, CompanyPersonnel>().ForMember(dest=>dest.ModifiedDate,opt=>opt.MapFrom(x=>DateTime.Now));
        }
    }
}
