
using FiveToSeven.Services.Minich6;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSeven.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Minich6Controller : ControllerBase
    {
        private readonly IMinich6Service _minich6Service;
        public Minich6Controller(IMinich6Service minich6Service)
        {
            _minich6Service = minich6Service;
            
        }
   [HttpGet]
    [Route("OddOrEven/{num}")]
    public string OddOrEvenMachine(string num){
        return _minich6Service.OddOrEvenMachine(num);
    }
    }
}