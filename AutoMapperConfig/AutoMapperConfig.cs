using AutoMapper;
using SourceType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TargetType;

namespace AutoMapperConfig
{
    public class AutoMapperConfig: Profile
    {
        public AutoMapperConfig()
        { 
            CreateMap<CustomOrder, CustomOrderDto>();
        }
    }
}
