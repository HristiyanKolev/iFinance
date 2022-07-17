using Microsoft.AspNetCore.Mvc;
using UserService.Models;
using UserServices.Contracts;

namespace iFinanceAPI.Controllers
{
    /// <summary>
    /// Controller for basic CRUD operations for Users
    /// </summary>
    [Route("api/[Controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserMethods _iUserService;

        public UsersController(IUserMethods iUserService)
        {
            this._iUserService = iUserService;
        }
        
        //GET api/[Controller]/
        [HttpGet]
        public ActionResult <IEnumerable<UserModel>> GetAllUsers()
        {
            var users = _iUserService.GetUsers();

            return Ok(users);
        }

        //GET api/[Controller]/{id}
        [HttpGet("{id}")]
        public ActionResult<UserModel> GetUserById(int id)
        {
            var user = _iUserService.GetUserByID(id);

            return Ok(user);
        }
    }
}
