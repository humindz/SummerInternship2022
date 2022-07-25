using System;
using System.ComponentModel.DataAnnotations;

namespace HumindZ.SummerInternship2022.Modules.Users.Business
{
    public class User
    {
        [Required()]
        public Guid Id { get; set; }

        [Required()]
        public string UserName { get; set; }

        [Required()]
        public string Password { get; set; }

    }

}
