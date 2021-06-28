using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceType
{
    /// <summary>
    /// 值转换器专用  （源类型）
    /// </summary>
    public class ValueOrder
    {
        public decimal Amount { get; set; } //总金额----（字符串）总金额 + 万元/元

        public string Description { get; set; }

        public ValueOrderLineItem ValueOrderLineItem { get; set; }
    }

    public class ValueOrderLineItem
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }
    }

}
