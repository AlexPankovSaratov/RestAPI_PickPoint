using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestAPI_PickPoint.Data;
using RestAPI_PickPoint.Models;

namespace RestAPI_PickPoint.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrdersController : Controller
    {
        private readonly MockOrderRepo _repository = new MockOrderRepo();

        //  api/orders
        [HttpGet]
        public ActionResult<IEnumerable<Order>> GetAllCommands()
        {
            return Ok(_repository.GetAppOrders());
        }
        //  api/orders/1
        [HttpGet("{id}")]
        public ActionResult<Order> GetOrderById(int id)
        {
            return Ok(_repository.GetOrderById(id));
        }
    }
}
