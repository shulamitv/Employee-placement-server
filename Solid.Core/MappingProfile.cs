using AutoMapper;
using Solid.Core.DTOs;
using Solid.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<EmployeeC, EmployeeDto>().ReverseMap();  
            CreateMap<CollegeC, CollegeDto>().ReverseMap();
            CreateMap<JobC, JobDto>().ReverseMap();
        }
    }
}
