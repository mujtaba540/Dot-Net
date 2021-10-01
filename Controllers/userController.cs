using practice.Models;
using Microsoft.AspNetCore.Mvc;

namespace practice.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class userController:ControllerBase{
        private user data=new user();

        [HttpGet]
        [Route("/")]
        public ActionResult<user> fun1(){
            return data;
        }
    }
    
}