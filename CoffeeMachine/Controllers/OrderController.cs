using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using CoffeeMachine.Business;
using CoffeeMachine.Dto;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoffeeMachine.Controllers
{
    [Route("api/[controller]")]
    public class OrderController : Controller
    {
        private OrderBLL _orderBLL;

        private OrderController()
        {
            _orderBLL = new OrderBLL();
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            throw new NotImplementedException();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            throw new NotImplementedException();
        }

        // POST api/<controller>
        [HttpPost]
        public IActionResult Post([FromBody]string value)
        {
            OrderDTO order;

            try
            {
                order = JsonSerializer.Deserialize<OrderDTO>(value);
            }
            catch
            {
                return BadRequest();
            }

            try
            {
                _orderBLL.Save(order);
            }
            catch
            {
                return StatusCode(500);
            }

            return StatusCode(201);
        }
    }
}
