using FiveToSeven.Services.Numeric;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSeven.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NumericController : ControllerBase
    {
        private readonly INumericService _numericService;
        public NumericController(INumericService numericService)
        {
            _numericService = numericService;
            
        }
        [HttpGet]
        [Route("ReverseNumber/{number2}")]
        public string ReverseIt(string number2)
        {
            return _numericService.ReverseIt(number2);
        }
    }
}