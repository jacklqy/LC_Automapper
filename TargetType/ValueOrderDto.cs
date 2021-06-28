using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetType
{
    /// <summary>
    /// 值转换器专用  （目标类型）
    /// </summary>
    public class ValueOrderDto
    {
        public string StrAmount { get; set; }

        public string Description { get; set; }
        
        public OrderLineItemDto ValueOrderLineItem { get; set; }
    }


    public class OrderLineItemDto
    {
        public int Id { get; set; }

        public string Name { get; set; }


        public string StrPrice { get; set; }
    }

}
