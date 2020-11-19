using RestAPI_PickPoint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI_PickPoint.Data
{
    interface IOrderRepo
    {
        public IEnumerable<Order> GetAppOrders();
        public Order GetOrderById(int id);
    }
}
