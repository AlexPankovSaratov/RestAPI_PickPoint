using RestAPI_PickPoint.DAL;
using RestAPI_PickPoint.Models;
using RestAPI_PickPoint.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI_PickPoint.BLL
{

    public class MockOrderLogic : IOrderLogic
    {
        private readonly IOrderRepo _orderRepo;
        private readonly IPostamatRepo _postmatRepo;
        public MockOrderLogic(IOrderRepo orderRepo, IPostamatRepo postamatRepo)
        {
            _orderRepo = orderRepo;
            _postmatRepo = postamatRepo;
        }

        public int CancelOrder(int targetNumber)
        {
            var order = _orderRepo.CancelOrder(targetNumber);
            if (order == null) return (int)ErrorStatuses.NotFound;
            return (int)ErrorStatuses.OK;
        }

        public Order CreateOrder(Order newOrder)
        {
            if (!Enum.IsDefined(typeof(OrderStatus), newOrder.status)) return null;
            if(newOrder.orderList.Length > 10) return null;
            Postamat postamat = _postmatRepo.GetPostamatByNumber(newOrder.deliveryNumber);
            if (postamat == null || postamat.status == false) return null;
            if (!Tools.Tools.PhoneNumberCorrect(newOrder.recipientPhone)) return null;
            return _orderRepo.CreateOrder(newOrder);
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _orderRepo.GetAllOrders();
        }

        public Order GetOrderByNumber(int targetNumber)
        {
            return _orderRepo.GetOrderByNumber(targetNumber);
        }

        public int UpdateOrder(Order updateOrder)
        {
            if (!Enum.IsDefined(typeof(OrderStatus), updateOrder.status)) return (int)ErrorStatuses.BadRequest;
            if (updateOrder.orderList.Length > 10) return (int)ErrorStatuses.BadRequest;
            Postamat postamat = _postmatRepo.GetPostamatByNumber(updateOrder.deliveryNumber);
            if (postamat == null) return (int)ErrorStatuses.BadRequest;
            if (postamat.status == false) return (int)ErrorStatuses.Forbidden;
            var order = _orderRepo.UpdateOrder(updateOrder);
            if (order == null) return (int)ErrorStatuses.NotFound;
            if (!Tools.Tools.PhoneNumberCorrect(updateOrder.recipientPhone)) return (int)ErrorStatuses.BadRequest;
            return (int)ErrorStatuses.OK;
        }
    }
}
