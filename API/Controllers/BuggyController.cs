using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BuggyController: BaseApiController // derive from
    {
        private readonly DataContext _context;
        public BuggyController(DataContext context) {   // injecting DataContext inside here, also using API.Data;
            _context = context; // initialising the field from the parameter
        }


        [Authorize] // we require the users to be authenticated
        [HttpGet("auth")]
        public ActionResult<string> GetSecret() {
            return "secret text";
        }

        [HttpGet("not-found")]
        public ActionResult<AppUser> GetNotFound() {
            var notFound = _context.Users.Find(-1);

            if (notFound == null) return NotFound();

            return Ok(notFound);
        }

        [HttpGet("server-error")]
        public ActionResult<string> GetServerError() {
            var serverError = _context.Users.Find(-1);

            var serverErrorToReturn = serverError.ToString();   // generate an exception from this particular method

            return serverErrorToReturn;
        }

        [HttpGet("bad-request")]
        public ActionResult<string> GetBadRequest() {
           return BadRequest("This was not a good request");
        }
    }
}