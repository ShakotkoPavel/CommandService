namespace CommandService.WebApi.Controllers
{
    using System;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("command/[controller]")]
    public class PlatformController : ControllerBase
    {
        public PlatformController()
        {
            
        }

        [HttpPost]
        public IActionResult Post()
        {
            Console.WriteLine("--------------->");
            return Ok();
        }
    }
}
