using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachine.Dto
{
    public class OrderDTO
    {
        public int OrderID { get; set; }
        public int SugarLevel { get; set; }

        public bool HasOwnMug { get; set; }

        public BadgeDTO Badge { get; set; }

        public DrinkDTO Drink { get; set; }
    }
}
