using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Aula.FluentValidation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public ActionResult Post([FromBody] UserRequest request)
        {
            return Ok();
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(new List<UserRequest>() { new UserRequest { Name = "Wellyngton", Email = "programevc@gmail.com", Age = 30 } });
        }
    }
}
