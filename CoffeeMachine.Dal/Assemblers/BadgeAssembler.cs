using CoffeeMachine.Dal.Models;
using CoffeeMachine.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeMachine.Dal.Assemblers
{
    internal static class BadgeAssembler
    {
        public static BadgeModel ToModel(this BadgeDTO source)
        {
            if(source == null)
            {
                return null;
            }

            return new BadgeModel
            {
                ID = source.BadgeID,
                OrderList = source.OrderList.Select(o => o.ToModel()).ToList()
            };
        }
    }
}
