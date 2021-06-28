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
    public class CustomResolver : IValueResolver<AnalysisResource, AnalysisDestination, int>
    {
        public int Resolve(AnalysisResource source, AnalysisDestination destination, int destMember, ResolutionContext context)
        { 
            return source.Value2 + source.Value1 + destMember;
        }
    }
}
