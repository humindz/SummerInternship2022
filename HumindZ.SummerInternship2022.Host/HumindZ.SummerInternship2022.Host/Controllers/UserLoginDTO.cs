using System.ComponentModel.DataAnnotations;

namespace HumindZ.SummerInternship2022.Host.Controllers
{
    public class UserLoginDTO
    {
        [Required()]
        public string UserName { get; set; }
        [Required()]
        public string Password { get; set; }
    }
}