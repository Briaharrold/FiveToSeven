
using FiveToSeven.Service.Minich10;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSeven.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class Minich10Controller : ControllerBase
    {
    private readonly IMinich10Service _Minich10Service;

    public Minich10Controller(IMinich10Service minich10Service)
{
            _Minich10Service = minich10Service;
}

    [HttpGet]
    [Route("MexicanThaiOrMongolian/{category}")]
    public string RestarauntPicker(string category){
        return _Minich10Service.RestarauntPicker(category);
    }
    }
  

    
