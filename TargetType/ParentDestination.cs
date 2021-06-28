using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetType
{
    public class ParentDestination
    {
        public int Value1 { get; set; }
    }

    public class ChildDestination : ParentDestination
    {
        public int Value2 { get; set; }
    }
}
