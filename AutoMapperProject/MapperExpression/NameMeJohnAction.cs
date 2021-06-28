using AutoMapper;
using SourceType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TargetType;

namespace AutoMapperProject.MapperExpression
{
    public class NameMeJohnAction : IMappingAction<SomePersonObject, SomeOtherPersonObject>
    {
        public void Process(SomePersonObject source, SomeOtherPersonObject destination, ResolutionContext context)
        { 
            source.Name = source.Name + "---测试";
        }
    }
}
