using CoffeeMachine.Dal.Repositories;
using CoffeeMachine.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachine.Business
{
    public class DrinkBLL
    {
        private DrinkRepository _drinkRepository;

        public DrinkBLL()
        {
            _drinkRepository = new DrinkRepository();
        }
        public List<DrinkDTO> List()
        {
            return _drinkRepository.List();
        }
    }
}
