using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RestAPI_PickPoint.BLL;
using RestAPI_PickPoint.Dtos;
using RestAPI_PickPoint.Models;
using RestAPI_PickPoint.Tools;

namespace RestAPI_PickPoint.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrdersController : Controller
    {
        private readonly IOrderLogic _logic;
        private readonly IMapper _mapper;

        public OrdersController(IOrderLogic logic, IMapper mapper)
        {
            _logic = logic;
            _mapper = mapper;
        }
        //  api/orders
        [HttpGet]
        public ActionResult<IEnumerable<OrderReadDto>> GetAllOrders()
        {
            var orders = _logic.GetAllOrders();
            return Ok(_mapper.Map<IEnumerable<OrderReadDto>>(orders));
        }
        //  api/orders/1
        [HttpGet("{number}")]
        public ActionResult<Order> GetOrderByNumber(int number)
        {
            Order order = _logic.GetOrderByNumber(number);
            if(order != null)
            {
                return Ok(_mapper.Map<OrderReadDto>(order));
            }
            return NotFound();
        }
        //  api/orders
        [HttpPost]
        public ActionResult<Order> CreateOrder(OrderCreateDto orderCreateDto)
        {
            var orderModel = _mapper.Map<Order>(orderCreateDto);
            var result = _logic.CreateOrder(orderModel);
            if (result == null) return BadRequest();
            return Ok(_mapper.Map<OrderReadDto>(result));
        }
        [HttpPut]
        public ActionResult<Order> UpdateOrder(OrderReadDto OrderReadDto)
        {
            var orderModel = _mapper.Map<Order>(OrderReadDto);
            int result = _logic.UpdateOrder(orderModel);
            if (result == (int)ErrorStatuses.NotFound) return NotFound();
            if (result == (int)ErrorStatuses.BadRequest) return BadRequest();
            if (result == (int)ErrorStatuses.Forbidden) return Forbid();
            return Ok();
        }
        [HttpDelete("{number}")]
        public ActionResult<Order> CancelOrder(int number)
        {
            int result = _logic.CancelOrder(number);
            if (result == (int)ErrorStatuses.NotFound) return NotFound();
            return Ok();
        }
    }
}
