using AutoMapper;
using AutoMapper.Configuration.Annotations;
using SourceType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetType
{
    //CustomOrder: 源类型
    //[AutoMap(typeof(CustomOrder))] //特性映射
    public class CustomOrderDto
    { 
        //[Ignore]//:忽略
        public string OrderType { get; set; }

       //[SourceMember("Remark")]
        public string Description { get; set; }
      
        public string Prefix { get; set; }

        public int Id { get; set; }
    }
}
