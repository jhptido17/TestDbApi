using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestDbApi.Interface;

namespace TestDbApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IRepositoryWrapper _repository;

        public UserController(IRepositoryWrapper repository)
        {
            _repository = repository;
        }

        //Implement LoggerManager NLog
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            try
            {
                var users = _repository.User.GetAllUsers();
                return Ok(users);
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById(Guid id)
        {
            try
            {
                var user = _repository.User.GetUserById(id);
 
                if (user.UserId.Equals(Guid.Empty))
                { 
                    return NotFound();
                }
                else
                {
                    return Ok(user);
                }
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}