using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController:ControllerBase
    {
        [HttpGet]
        public string SayHi(){
            return "Hi";
        }
    }
}