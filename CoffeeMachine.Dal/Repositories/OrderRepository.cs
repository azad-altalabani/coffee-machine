using CoffeeMachine.Dal.Assemblers;
using CoffeeMachine.Dal.Models;
using CoffeeMachine.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachine.Dal.Repositories
{
    public class OrderRepository
    {
        public void Save(OrderDTO order)
        {
            using (var context = new CoffeMachineDbContext())
            {
                OrderModel model = order.ToModel();

                context.Orders.Add(model);
                context.SaveChanges();
            }
        }
    }
}
