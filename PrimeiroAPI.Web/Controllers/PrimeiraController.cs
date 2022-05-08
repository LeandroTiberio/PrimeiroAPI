using Microsoft.AspNetCore.Mvc;
namespace PrimeiroAPI.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class PrimeiraController : ControllerBase
    {
        [HttpGet]

        public string PrimeiraAPI()
        {
            return "Teste";
        }
        [HttpGet("segundoApi")]
        public string SegundaAPI()
        { 
            return "TesteDois";
        }   
        [HttpGet("terceiraApi")]
        public IActionResult OutraAPI(int entrada)
        {
            if(entrada ==1)
            {
                return BadRequest("1 Não é uma entrada valída");
            }
            return Ok(entrada);
        } 
    }
}






