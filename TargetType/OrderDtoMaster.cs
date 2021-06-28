using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetType
{
    public class OrderDtoMaster
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

    public class OnlineOrderDto : OrderDtoMaster
    {

    }
    public class MailOrderDto : OrderDtoMaster
    {

    }
}
