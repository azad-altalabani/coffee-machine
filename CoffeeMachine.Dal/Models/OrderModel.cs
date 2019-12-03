using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachine.Dal.Models
{
    public class OrderModel
    {
        public int ID { get; set; }
        public int SugarLevel { get; set; }

        public bool HasOwnMug { get; set; }

        public BadgeModel Badge { get; set; }

        public DrinkModel Drink { get; set; }
    }
}
