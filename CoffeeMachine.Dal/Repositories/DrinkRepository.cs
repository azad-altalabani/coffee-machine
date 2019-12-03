using CoffeeMachine.Dal.Assemblers;
using CoffeeMachine.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeMachine.Dal.Repositories
{
    public class DrinkRepository
    {
        public List<DrinkDTO> List()
        {
            List<DrinkDTO> drinkList;
            using (var context = new CoffeMachineDbContext())
            {
                drinkList = context.Drinks.Select(d => d.ToDto()).ToList();
            }

            return drinkList;
        }
    }
}
