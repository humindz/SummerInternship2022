using HumindZ.SummerInternship2022.Business.Repositories.UserRepository;

using System.Threading.Tasks;

namespace HumindZ.SummerInternship2022.Services.User
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public async Task<UserDto> GetUserByUserName(string userName)
        {
            var result = await userRepository.GetByUserNameAsync(userName);

            return result == null ? null : new UserDto
            {
                Id = result.Id,
                FullName = result.FullName,
                UserName = result.UserName,
                Password = result.Password
            };
        }
    }
}
