namespace HumindZ.SummerInternship2022.Host.Controllers
{
    using HumindZ.SummerInternship2022.Services.User;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

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
    }
}
