using AutoMapper;
using DemoCleanArch.Domain.Dtos;
using DemoCleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCleanArch.Domain.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Todo, TodoDto>().ReverseMap();
        }
    }
}
