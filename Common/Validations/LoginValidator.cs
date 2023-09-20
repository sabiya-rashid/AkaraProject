using Common.DTOs.UserDto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Common.Validations
{
    public class LoginValidator:AbstractValidator<LoginDto>
    {
          public LoginValidator() 
          {
            RuleFor(c => c.Email).EmailAddress().WithMessage("Please provide valid email address");
            RuleFor(c => c.Password).NotNull().NotEmpty().WithMessage("Password is required");           
          }
    }
}
