namespace HumindZ.SummerInternship2022.Host.Controllers
{
    using FluentValidation.Results;
    using HumindZ.SummerInternship2022.Services.User;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Threading.Tasks;
    using Tweetinvi.Core.DTO;

    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet("{userName}")]
        public async Task<ActionResult<UserDto>> Get(string userName)
        {
            return await userService.GetUserByUserName(userName);
        }


        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<ActionResult<UserDTO>> Login([FromBody] UserLoginDTO userParam)
        {
            UserLoginDTOValidator validator = new UserLoginDTOValidator();

            FluentValidation.Results.ValidationResult validationResult = validator.Validate(userParam);

            if (validationResult.IsValid)
            {
                var result = await userService.Login(userParam.UserName, userParam.Password);
                if (result == null)
                {
                    return Unauthorized();
                }
                return Ok(result);
            }
            else
            {
                var errors = new List<string>();
                foreach (ValidationFailure failer in validationResult.Errors)
                {
                    errors.Add(failer.ErrorMessage);
                }
                return Unauthorized(errors);
            }

        }
    }
}
