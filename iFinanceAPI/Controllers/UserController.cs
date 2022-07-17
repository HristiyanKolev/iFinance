using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UserServices.Contracts;
using UserService.Models;
using ResponseModels.UserResponseModels;
using InputModels.UserInputModels;
using Microsoft.AspNetCore.JsonPatch;

namespace iFinanceAPI.Controllers
{
    /// <summary>
    /// Controller for basic CRUD operations for Users
    /// </summary>
    [Route("api/[Controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMapper _iMapper;
        private readonly IUserService _iUserService;

        public UserController(IMapper iMapper, IUserService iUserService)
        {
            this._iMapper = iMapper;
            this._iUserService = iUserService;
        }

        //GET api/[Controller]/
        /// <summary>
        /// Returns a list of all users from DB
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<IEnumerable<UserResponseModel>> GetAllUsers()
        {
            IEnumerable<UserServiceModel> users = _iUserService.GetUsers();
            if (users == null)
            {
                return NotFound();
            }

            IEnumerable<UserResponseModel> responseList = _iMapper.Map<IEnumerable<UserResponseModel>>(users);
            return Ok(responseList);
        }

        //GET api/[Controller]/{id}
        /// <summary>
        /// Returns a User by ID
        /// </summary>
        /// <param name="id">User ID</param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "GetUserById")]
        public ActionResult<UserResponseModel> GetUserById(int id)
        {
            UserServiceModel user = _iUserService.GetUserByID(id);
            if (user == null)
            {
                return NotFound();
            }

            UserResponseModel response = _iMapper.Map<UserResponseModel>(user);
            return Ok(response);
        }

        //POST api/[Controller]
        /// <summary>
        /// Create a new User
        /// </summary>
        /// <param name="userInputModel">User model</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<UserInputModel> CreateUser(UserInputModel userInputModel)
        {
            if (userInputModel == null)
            {
                return NoContent();
            }

            UserServiceModel userServiceModel = _iMapper.Map<UserServiceModel>(userInputModel);
            _iUserService.CreateUser(userServiceModel);

            return CreatedAtRoute(nameof(GetUserById), new { Id = userServiceModel.Id }, userServiceModel);
        }

        //PUT api/[Controller]/{id}
        /// <summary>
        /// Update User model with matching ID
        /// </summary>
        /// <param name="id">User ID</param>
        /// <param name="userInputModel">User model</param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public ActionResult<UserInputModel> UpdateUser(int id, UserInputModel userInputModel)
        {
            if (userInputModel == null)
            {
                return NoContent();
            }

            UserServiceModel userServiceModel = _iUserService.GetUserByID(id);
            _iMapper.Map(userInputModel, userServiceModel);
            _iUserService.UpdateUser(userServiceModel);

            return NoContent();
        }

        /// <summary>
        /// Partially Update a User with matching ID
        /// </summary>
        /// <param name="id">User ID</param>
        /// <param name="patchDocument">Patch Document</param>
        /// <returns></returns>
        [HttpPatch("{id}")]
        public ActionResult PartialUserUpdate(int id, JsonPatchDocument<UserInputModel> patchDocument)
        {
            UserServiceModel userServiceModel = _iUserService.GetUserByID(id);
            if (userServiceModel == null)
            {
                return NoContent();
            }

            UserInputModel userInputModel = _iMapper.Map<UserInputModel>(userServiceModel);
            patchDocument.ApplyTo(userInputModel, ModelState);

            if (!TryValidateModel(userInputModel))
            {
                return ValidationProblem(ModelState);
            }

            _iMapper.Map(userInputModel, userServiceModel);
            _iUserService.UpdateUser(userServiceModel);

            return NoContent();
        }

        [HttpDelete]
        public ActionResult DeleteCommand(int id)
        {
            UserServiceModel userServiceMode = _iUserService.GetUserByID(id);
            if (userServiceMode == null)
            {
                return NoContent();
            }

            _iUserService.DeleteUser(userServiceMode);

            return NoContent();
        }
    }
}
