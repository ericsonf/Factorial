using Microsoft.AspNetCore.Mvc;

namespace Factorial.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FactorialController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(uint number) =>
            number < 1 || number > 65
                ? BadRequest("The number must be between 1 and 65.")
                : Ok($"The factorial of the number {number} is {new Factorial().Calculate(number)}.") as IActionResult;
    }
}
