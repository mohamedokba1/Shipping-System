﻿using Microsoft.AspNetCore.Mvc;
using Shipping.Services.Dtos;
using Shipping.Services.IServices;
using System.ComponentModel.DataAnnotations;

namespace Shipping.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly ITraderService _traderService;
        public OrdersController(
            IOrderService orderService,
            ITraderService traderService)
        {
            _orderService = orderService;
            _traderService = traderService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderReadDto>>> GetAll(string userEmail)
        {
            var orders = await _orderService.GetAllOrdersAsync(userEmail);
            return Ok(orders);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<OrderReadDto>> GetById(long id)
        {
            var order = await _orderService.GetOrderByIdAsync(id);
            if (order == null)
                return NotFound();
            return Ok(order);
        }

        [HttpPost]
        public async Task<ActionResult> Add(OrderAddDto order, string userEmail)
        {
            List<ValidationResult>? errors =  await _orderService.AddOrderAsync(order, userEmail);
            if(errors?.Count ==0)
            {
                return Ok(order);
            }
            else
                return BadRequest();
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<ActionResult> Update(long id, OrderUpdateDto order)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var oldOrder = await _orderService.GetOrderByIdAsync(id);
            if (oldOrder == null)
                return NotFound();
            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult> Delete(long id)
        {
            var order = await _orderService.GetOrderByIdAsync(id);
            if (order == null)
                return NotFound();
            
            await _orderService.DeleteOrderAsync(id);
            return NoContent();
        }
    }
}