using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UdemyApp.Data;
using UdemyApp.Dtos;
using UdemyApp.Models;

namespace UdemyApp.Controllers
{
    [Route("api/")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository repository;

        public AuthController(IAuthRepository repository)
        {
            this.repository = repository;
        }
        [HttpPost("register")]
        public async Task<IActionResult> Register(UserForRegisterDto userForRegisterDto)
        {
            userForRegisterDto.UserName = userForRegisterDto.UserName.ToLower();

            if (await repository.UserExist(userForRegisterDto.UserName))
                return BadRequest("Username already exist");

            var userToCreate = new User()
            {
                Name = userForRegisterDto.UserName
            };

            var createdUser = await repository.Register(userToCreate, userForRegisterDto.Password);

            return StatusCode(201);
        }
    }
}
