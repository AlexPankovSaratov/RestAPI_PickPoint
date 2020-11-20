using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RestAPI_PickPoint.Data;
using RestAPI_PickPoint.Dtos;
using RestAPI_PickPoint.Models;

namespace RestAPI_PickPoint.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrdersController : Controller
    {
        private readonly IOrderRepo _repository;
        private readonly IMapper _mapper;

        public OrdersController(IOrderRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        //  api/orders
        [HttpGet]
        public ActionResult<IEnumerable<OrderReadDto>> GetAllCommands()
        {
            var orders = _repository.GetAllOrders();
            return Ok(_mapper.Map<IEnumerable<OrderReadDto>>(orders));
        }
        //  api/orders/1
        [HttpGet("{id}")]
        public ActionResult<Order> GetOrderById(int id)
        {
            Order order = _repository.GetOrderById(id);
            if(order != null)
            {
                return Ok(_mapper.Map<OrderReadDto>(order));
            }
            return NotFound();
        }
        [HttpPost]
        public ActionResult<string> CreateOrder(OrderCreateDto orderCreateDto)
        {
            var orderModel = _mapper.Map<Order>(orderCreateDto);
            _repository.CreateOrder(orderModel);
            return "урааа";
        }
    }
}
