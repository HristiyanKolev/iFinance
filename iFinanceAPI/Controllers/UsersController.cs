using iFinanceAPI.Data;
using iFinanceAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace iFinanceAPI.Controllers
{
    /// <summary>
    /// Controller for basic CRUD operations for Users
    /// </summary>
    [Route("api/[Controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepo _repository;

        public UsersController(IUserRepo repository)
        {
            this._repository = repository;
        }
        
        //GET api/[Controller]/
        [HttpGet]
        public ActionResult <IEnumerable<User>> GetAllUsers()
        {
            var users = _repository.GetUsers();

            return Ok(users);
        }

        //GET api/[Controller]/{id}
        [HttpGet("{id}")]
        public ActionResult<User> GetUserById(int id)
        {
            var user = _repository.GetUserByID(id);

            return Ok(user);
        }
    }
}
