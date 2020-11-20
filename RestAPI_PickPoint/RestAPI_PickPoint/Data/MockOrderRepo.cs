using RestAPI_PickPoint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI_PickPoint.Data
{
    public class MockOrderRepo : IOrderRepo
    {
        public void CreateOrder(Order newOrder)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetAllOrders()
        {
            var orders = new List<Order>
            {
                new Order {
                number = 123, status = 31, orderList = new string[] { "", "", "" }, cost = 15, deliveryNumber = 123, recipientPhone = "", FIO = ""
            },
                new Order {
                number = 123, status = 31, orderList = new string[] { "", "", "" }, cost = 15, deliveryNumber = 123, recipientPhone = "", FIO = ""
            },
                new Order {
                number = 123, status = 31, orderList = new string[] { "", "", "" }, cost = 15, deliveryNumber = 123, recipientPhone = "", FIO = ""
            }
            };
            return orders;
        }

        public Order GetOrderById(int id)
        {
            return new Order
            {
                number = 123,
                status = 31,
                orderList = new string[] { "", "", "" },
                cost = 15,
                deliveryNumber = 123,
                recipientPhone = "",
                FIO = ""
            };
        }
    }
}
