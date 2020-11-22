using RestAPI_PickPoint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI_PickPoint.DAL
{
    public class MockOrderRepo : IOrderRepo
    {
        private static List<Order> _AllOrders;

        public MockOrderRepo()
        {
            if(_AllOrders == null) _AllOrders = new List<Order>();
        }

        public Order CancelOrder(int targetNumber)
        {
            Order order = _AllOrders.FirstOrDefault(Order => Order.number == targetNumber);
            if (order == null) return null;
            order.status = (int)OrderStatus.Canceled;
            _AllOrders[_AllOrders.IndexOf(order)] = order;
            return order;
        }

        public Order CreateOrder(Order newOrder)
        {
            newOrder.number = _AllOrders.Count() + 1;
            _AllOrders.Add(newOrder);
            return newOrder;
        }

        public IEnumerable<Order> GetAllOrders()
        {
            foreach (Order item in _AllOrders)
            {
                yield return item;
            }
        }

        public Order GetOrderByNumber(int targetNumber)
        {
            return _AllOrders.FirstOrDefault(Order => Order.number == targetNumber);
        }

        public Order UpdateOrder(Order updateOrder)
        {
            Order order = _AllOrders.FirstOrDefault(Order => Order.number == updateOrder.number);
            if (order == null) return null;
            order.orderList = updateOrder.orderList;
            order.cost = updateOrder.cost;
            order.deliveryNumber = updateOrder.deliveryNumber;
            order.recipientPhone = updateOrder.recipientPhone;
            order.FIO = updateOrder.FIO;
            _AllOrders[_AllOrders.IndexOf(order)] = order;
            return order;
        }
    }
}
