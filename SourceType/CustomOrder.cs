using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceType
{
    public class CustomOrder
    {
        public OrderTypeEnum OrderType { get; set; }

        public string Description { get; set; }
         
       public string Prefix { get; set; }

        public int Id { get; set; }

    }

    public enum OrderTypeEnum
    {
        FirstOrder = 1,
        SecondOrder = 2,
        ThirdOrder = 3
    }
}
