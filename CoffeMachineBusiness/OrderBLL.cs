using CoffeeMachine.Dal.Repositories;
using CoffeeMachine.Dto;
using System;

namespace CoffeeMachine.Business
{
    public class OrderBLL
    {
        private OrderRepository _orderRepository;
        private BadgeRepository _badgeRepository;

        public OrderBLL()
        {
            _orderRepository = new OrderRepository();
            _badgeRepository = new BadgeRepository();
        }

        public bool Validate(OrderDTO order)
        {
            if(order.SugarLevel < 1 || order.SugarLevel > 9)
            {
                return false;
            }

            return true;
        }

        public void Save(OrderDTO order)
        {
            if(order.Badge != null)
            {
                _badgeRepository.Save(order.Badge);
            }

            if(Validate(order))
            {
                _orderRepository.Save(order);
            }
        }
    }
}
