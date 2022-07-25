using System.Threading.Tasks;

namespace HumindZ.SummerInternship2022.Business.Repositories.UserRepository
{
    public interface IUserRepository
    {
        Task<User> GetByUserNameAsync(string userName);
    }
}
