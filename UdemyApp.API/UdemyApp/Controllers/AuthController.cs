using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using UdemyApp.Data;
using UdemyApp.Dtos;
using UdemyApp.Models;

namespace UdemyApp.Controllers
{
    [Route("api/auth/")]
    //[ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository repository;
        private readonly IConfiguration config;

        public AuthController(IAuthRepository repository, IConfiguration config)
        {
            this.repository = repository;
            this.config = config;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody]UserForLoginDto userForLoginDto)
        {

            if (ModelState.IsValid)
             return BadRequest(); 

            userForLoginDto.UserName = userForLoginDto.UserName.ToLower();

            if (await repository.UserExist(userForLoginDto.UserName))
                return BadRequest();

            var userForCreation = new User()
            {
                Name = userForLoginDto.UserName
            };

            var CreatedUser = repository.Register(userForCreation, userForLoginDto.Password);
           
            return StatusCode(201);
        }
       
    }
}
