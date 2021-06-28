using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceType
{
    public class ParentSource
    {
        public int Value1 { get; set; }
    }

    public class ChildSource : ParentSource
    {
        public int Value2 { get; set; }
    }
}
