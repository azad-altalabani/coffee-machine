using CoffeeMachine.Dal;
using Microsoft.EntityFrameworkCore;
using System;

namespace CoffeMachine.DbInstantiator
{
    class Program
    {
        static void Main(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CoffeMachineDbContext>();
            CoffeMachineDbContext context = new CoffeMachineDbContext(optionsBuilder.Options);
            context.Database.EnsureCreatedAsync();
        }
    }
}
