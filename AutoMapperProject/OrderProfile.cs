using AutoMapper;
using SourceType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TargetType;

namespace AutoMapperProject
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            base.CreateMap<Source, Dest>();
            //base.CreateMap<Source, Dest>();
            //base.CreateMap<Source, Dest>();
            //base.CreateMap<Source, Dest>();
            //base.CreateMap<Source, Dest>();
        }
    }
}
