using AutoMapper;
using CompanyEmployee.Entities.DTOs;
using CompanyEmployee.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyEmployee.API.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Company, CompanyDto>()
                .ForMember(c => c.FullAddress,
                    opt => opt.MapFrom(x => string.Join(' ', x.Address, x.Country)));
        }
    }
}
