using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachine.Dto
{
    public class BadgeDTO
    {
        public int BadgeID { get; set; }

        public List<OrderDTO> OrderList { get; set; }
    }
}
