using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetType
{
    public class GenericResultDto<T>
    {
        public T Value { get; set; }
    }
}
