using CoffeeMachine.Business;
using CoffeeMachine.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Text.Json;

namespace CoffeeMachine.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrinkController : ControllerBase
    {
        private DrinkBLL _drinkBLL;

        public DrinkController()
        {
            _drinkBLL = new DrinkBLL();
        }

        // GET: api/Drink
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_drinkBLL.List().Select(d => JsonSerializer.Serialize<DrinkDTO>(d)));
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}
