using Microsoft.AspNetCore.Mvc;

namespace Factorial.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FactorialController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(uint number) =>
            number is < 1 or > 65
                ? BadRequest("The number must be between 1 and 65.")
                : Ok($"The factorial of the number {number} is {Factorial.Calculate(number)}.");
    }
}
