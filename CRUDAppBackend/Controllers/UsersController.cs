using CRUDAppBackend.Models;
using CRUDAppBackend.UserData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace CRUDAppBackend.Controllers
{
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserData _userData;
        public UsersController(IUserData userData)
        {
            _userData = userData;
        }
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetUsers()
        {
            return Ok(_userData.GetUsers());
        }
        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetUser(int id)
        {
            var usertmp = _userData.GetUser(id);
            if (usertmp != null)
            {
               return Ok(usertmp);
            }
            return NotFound($"User with id: {id} not found!");
        }
        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult CreateUser(User user)
        {
            _userData.AddUser(user);
            return Created(HttpContext.Request.Scheme + "://" 
                + HttpContext.Request.Host 
                + HttpContext.Request.Path + "/" 
                + user.Id, user
                );
            
        }
        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DeleteUser(int id)
        {
            var usertmp = _userData.GetUser(id);
            if(usertmp != null)
            {
                _userData.DeleteUser(usertmp);
                return Ok($"Delete user {usertmp.Name}");
            }
            return NotFound($"User with id: {id} not found!");
        }

    }
}
