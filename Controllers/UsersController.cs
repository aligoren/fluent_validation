using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace fluent_validation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        

        [HttpPost]
        public IActionResult Create([FromForm] User user)
        {
            if (!ModelState.IsValid)
            {
                return UnprocessableEntity(user);
            }

            return Ok(user);
        }
    }
}
