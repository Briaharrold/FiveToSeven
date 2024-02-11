
using FiveToSeven.Services.SayHello;
using Microsoft.AspNetCore.Mvc;

namespace SayHelloController.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SayHelloController : ControllerBase
    {
        public ISayHelloService _SayHelloService;
        public SayHelloController(ISayHelloService sayHelloService)
        {
            _SayHelloService = sayHelloService;
        
        }
        [HttpGet]
        [Route("SayHello/{name}")]
        public string SayHello(string name)
        {
            return _SayHelloService.SayHello2(name);
        }
    }
}