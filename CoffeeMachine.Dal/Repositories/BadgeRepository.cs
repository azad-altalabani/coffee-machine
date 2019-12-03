using CoffeeMachine.Dal.Models;
using CoffeeMachine.Dal.Assemblers;
using CoffeeMachine.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachine.Dal.Repositories
{
    public class BadgeRepository
    {
        public void Save(BadgeDTO badge)
        {
            using (var context = new CoffeMachineDbContext())
            {
                BadgeModel model = badge.ToModel();

                context.Badges.Add(model);
                context.SaveChanges();
            }
        }
    }
}
