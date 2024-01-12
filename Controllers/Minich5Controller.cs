using FiveToSeven.Services.Minich5;
using Microsoft.AspNetCore.Mvc;
namespace FiveToSeven.Controllers;

[ApiController]
[Route("api/[controller]")]
public class Minich5Controller : ControllerBase
{
        private readonly IMinich5Service _minich5Service;
public Minich5Controller(IMinich5Service minich5Service)
{
            _minich5Service = minich5Service;
    
}
     [HttpGet]
        [Route("Minich5/{noun1}/{noun2}/{noun3}/{verb1}/{verb2}")]
        public string MadLib(string noun1,string noun2,string noun3,string verb1,string verb2){
            return _minich5Service.MadLib(noun1,noun2,noun3,verb1,verb2);
        }
  
}
