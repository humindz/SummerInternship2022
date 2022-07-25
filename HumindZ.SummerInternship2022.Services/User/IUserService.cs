using System.Threading.Tasks;

namespace HumindZ.SummerInternship2022.Services.User
{
    public interface IUserService
    {
        Task<UserDto> GetUserByUserName(string userName);
    }
}
