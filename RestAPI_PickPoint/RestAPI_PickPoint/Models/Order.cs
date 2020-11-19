using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI_PickPoint.Models
{
    enum OrderStatus
    {
        Registered = 1,
        AcceptedInStock = 2,
        IssuedToCourier = 3,
        DeliveredAtCheckpoint = 4,
        DeliveredTorecipient = 5,
        Canceled = 6
    }
    public class Order
    {
        public int number { get; set; }
        public int status { get; set; }
        public string[] orderList { get; set; }
        public decimal cost { get; set; }
        public int deliveryNumber { get; set; }
        public string recipientPhone { get; set; }
        public string FIO { get; set; }
    }
}
