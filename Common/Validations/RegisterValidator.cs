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
    public class RegisterValidator : AbstractValidator<RegisterDto>
    {
        public RegisterValidator()
        {
            RuleFor(c => c.Email).EmailAddress().WithMessage("Please provide valid email address");
            RuleFor(c => c.Phone).NotNull().NotEmpty().WithMessage("Phone number is required");
            RuleFor(x => x.Password).NotNull().NotEmpty().WithMessage("Password is required.")
               .MinimumLength(8).WithMessage("YourProperty must be at least 8 characters long.")
               .Must(HaveSpecialCharacter).WithMessage("YourProperty must contain at least one special character.")
               .Must(HaveCapitalLetter).WithMessage("YourProperty must contain at least one capital letter.");
        }
        private bool HaveSpecialCharacter(string input)
        {
            return Regex.IsMatch(input, @"[!@#$%^&*()_+{}\[\]:;<>,.?~\\-]");
        }

        private bool HaveCapitalLetter(string input)
        {
            return input.Any(char.IsUpper);
        }
    }
}
