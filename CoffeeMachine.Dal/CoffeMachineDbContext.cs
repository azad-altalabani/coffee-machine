using CoffeeMachine.Dal.Models;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;

namespace CoffeeMachine.Dal
{
    public class CoffeMachineDbContext : DbContext
    {
        #region Properties
        public DbSet<OrderModel> Orders { get; set; }

        public DbSet<BadgeModel> Badges { get; set; }

        public DbSet<DrinkModel> Drinks { get; set; }

        #endregion

        #region Constructors

        public CoffeMachineDbContext(DbContextOptions options) : base(options)
        {
        }

        internal CoffeMachineDbContext()
        {
        }

        #endregion

        #region Private methods
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(local);Database=CoffeMachine_Dev;Trusted_Connection=True;");
        }

        #endregion
    }
}
