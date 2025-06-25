using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShippingAPI.DTOS.OrderDTOs;
using ShippingAPI.Models;
using ShippingAPI.UnitOfWorks;

namespace ShippingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        IMapper mapper;
        UnitOfWork unit;

        public OrderController(UnitOfWork unit, IMapper mapper)
        {
            this.unit = unit;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult getAllOrders()
        {
            var orders = unit.OrderRepo.getAll();
            if (orders == null || !orders.Any())
            {
                return NotFound("No Orders Founded");
            }
            List<displayOrderDTO> result = mapper.Map<List<displayOrderDTO>>(orders);
            return Ok(result);

        }

        [HttpGet("{id}")]
        public IActionResult getOrderById(int id) {
            var order = unit.OrderRepo.getByIdWithObj(id);
            if (order == null) {
                return NotFound($"Order with ID {id} not found.");
            }
            displayOrderDTO result = mapper.Map<displayOrderDTO>(order);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult addOrder(addOrderDTO orderDTO) {
            if (orderDTO == null) {
                return BadRequest("Invalid Order data");
            }
            var order = mapper.Map<Order>(orderDTO);
            unit.OrderRepo.add(order);
            unit.save();
            displayOrderDTO result = mapper.Map<displayOrderDTO>(unit.OrderRepo.getByIdWithObj(order.Id));
            return Ok(result);
        }
    }
}
