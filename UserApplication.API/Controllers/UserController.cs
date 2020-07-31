using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UserApplicationDAL.Entities;
using UserApplicationService;

namespace UserApplication.API.Controllers
{
    [ApiController]
    [Route("users")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserApplicationRepository _userService;

        public UserController(ILogger<UserController> logger, IUserApplicationRepository userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpGet]
        [Route("all")]
        [ProducesResponseType(typeof(IEnumerable<User>), (int)HttpStatusCode.OK)]
        public IActionResult GetAll()
        {
            return Ok(_userService.GetAllUsers());
        }

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<IActionResult> Create([FromBody] User newUser)
        {
            await _userService.Insert(newUser);

            return Ok();
        }

        [HttpDelete("{userId:int}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public IActionResult Delete(int userId)
        {
            _userService.Delete(userId);

            return Ok(userId);
        }

        [HttpPut("{userId:int}")]
        [ProducesResponseType(typeof(IEnumerable<User>), (int)HttpStatusCode.OK)]
        public IActionResult Update(int userId, [FromBody] User newUserInfo)
        {
            return Ok(_userService.Update(userId, newUserInfo));
        }
    }
}
