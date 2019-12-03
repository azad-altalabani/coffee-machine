using CoffeeMachine.Dal.Models;
using CoffeeMachine.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachine.Dal.Assemblers
{
    internal static class OrderAssembler
    {
        public static OrderModel ToModel(this OrderDTO source)
        {
            if (source == null)
            {
                return null;
            }

            return new OrderModel
            {
                ID = source.OrderID,
                SugarLevel = source.SugarLevel,
                HasOwnMug = source.HasOwnMug,
                Drink = source.Drink.ToModel(),
                Badge = source.Badge.ToModel()
            };
        }
    }
}
