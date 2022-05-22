using Sushi.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sushi.BL
{
    public class SushiSetService : ISushiSetService
    {
        private IRepository<SushiSet> _sushiRepository = new SushiSetRepository<SushiSet>();

        private IRepository<Order> _orderRepository = new OrderRepository<Order>();

        public void AddSet(SushiSet sushiSet)
        {
            _sushiRepository.Add(sushiSet);
        }

        public List<SushiSet> GetSushiList()
        {
            var allSushiSet = _sushiRepository.GetAll();
            return allSushiSet.Select(s => (SushiSet)s).ToList();
        }

        public Order AddSushiToOrder(int setId, int orderId) 
        {
            var sushiSet = _sushiRepository.Get(setId);

            var order = _orderRepository.Get(orderId);
            if (order == null)
            {
                order = new Order();

                order.SushiSet.Add(sushiSet);
            }
            else 
            {
                order.SushiSet.Add(sushiSet);
            }

            _orderRepository.Add(order);

            return order;
        }
    }
}