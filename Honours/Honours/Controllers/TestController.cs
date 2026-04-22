using Honours.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Collections;

namespace Honours.Controllers
{
    [ApiController]
    [Route("[controller]/[Action]")]
    public class TestController : ControllerBase
    {
        public TestController() 
        {
            
        }
        [HttpGet]
        public IActionResult Hello()
        {
            return Ok("Hello World");
        }
        [HttpGet]
        public IActionResult Test()
        {
            User _user = new User(Guid.NewGuid(), "Emma", "hodkin@duck.com");
            return Ok(_user.ToString());
        }
    }
}
