using RestAPI_PickPoint.Models;
using RestAPI_PickPoint.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI_PickPoint.BLL
{
    public interface IOrderLogic
    {
        IEnumerable<Order> GetAllOrders();
        Order GetOrderByNumber(int targetNumber);
        Order CreateOrder(Order newOrder);
        int UpdateOrder(Order updateOrder);
        int CancelOrder(int targetNumber);
    }
}
