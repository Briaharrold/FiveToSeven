
using FiveToSeven.Services.Alphanumeric;
using Microsoft.AspNetCore.Mvc;
namespace FiveToSeven.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class AlphanumericController : ControllerBase
    {
        private readonly IMinich7Service _minich7Service;
        public AlphanumericController(IMinich7Service minich7Service)
        {
            _minich7Service = minich7Service;
            
        }
        [HttpGet]
        [Route("ReverseIt/{word}")]
        public string ReverseItAlpha(string word){
            return _minich7Service.ReverseItAlpha(word);
        }
    }
