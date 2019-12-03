using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachine.Dal.Models
{
    public class BadgeModel
    {
        public int ID { get; set; }

        public IList<OrderModel> OrderList { get; set; }
    }
}
