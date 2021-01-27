using GitHub_UserInfo_API.Data;
using GitHub_UserInfo_API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace GitHub_UserInfo_API.Controllers
{
    [Route("api")]
    [ApiController]
    public class GitController : ControllerBase
    {
        private readonly MockCommanderRepo _repository = new MockCommanderRepo();

        //GET api/user/{username}
        [HttpGet("{username}")]
        public ActionResult<Command> GetCommandByName(string userName)
        {
            var commandItem = _repository.GetCommandByName(userName);

            return Ok(commandItem);
        }
    }
}
