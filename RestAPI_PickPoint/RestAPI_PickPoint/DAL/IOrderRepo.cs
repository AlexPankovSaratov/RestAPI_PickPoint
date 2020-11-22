using RestAPI_PickPoint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI_PickPoint.DAL
{
    public interface IOrderRepo
    {
        IEnumerable<Order> GetAllOrders();
        Order GetOrderByNumber(int targetNumber);
        Order CreateOrder(Order newOrder);
        Order UpdateOrder(Order updateOrder);
        Order CancelOrder(int targetNumber);
    }
}
