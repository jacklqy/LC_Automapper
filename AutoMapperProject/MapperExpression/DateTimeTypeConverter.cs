using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperProject.MapperExpression
{

    /// <summary>
    /// 扩展了一个自定义规则
    /// </summary>
    public class DateTimeTypeConverter : ITypeConverter<string, DateTime>
    {
        public DateTime Convert(string source, DateTime destination, ResolutionContext context)
        {
            //在这里就可以自定义这个转换逻辑
            try
            {
                return System.Convert.ToDateTime(source);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
                
            }
             
        }
    }
}
