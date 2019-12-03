using CoffeeMachine.Business;
using CoffeeMachine.Dto;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CoffeMachine.Business.Tests
{
    [TestClass]
    public class OrderBLLTests
    {
        [TestMethod]
        public void Save_NoBadge_Test()
        {
            DrinkBLL drinkBll = new DrinkBLL();
            List<DrinkDTO> drinkList = drinkBll.List();
            DrinkDTO drink = drinkList?.FirstOrDefault(d => d.Code.Equals("COF"));

            Assert.IsNotNull(drink);

            OrderDTO order = new OrderDTO
            {
                Drink = drink,
                SugarLevel = 2,
                HasOwnMug = true,
                Badge = null
            };

            OrderBLL bll = new OrderBLL();
            bll.Save(order);
        }
    }
}
