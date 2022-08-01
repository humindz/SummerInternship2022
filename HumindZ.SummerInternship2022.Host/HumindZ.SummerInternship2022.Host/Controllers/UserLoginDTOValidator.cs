using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace HumindZ.SummerInternship2022.Host.Controllers
{
    public class UserLoginDTOValidator : AbstractValidator<UserLoginDTO>
    {
        public UserLoginDTOValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("UserName is required");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is required"); 
            RuleFor(x => x.Password).MinimumLength(6).WithMessage("Password must have at least 6 characters.");
        }
    }
}
