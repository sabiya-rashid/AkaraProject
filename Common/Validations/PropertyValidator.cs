using Common.DTOs.Property;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Common.Validations
{
    public class PropertyValidator:AbstractValidator<PropertyDto>
    {
        public PropertyValidator() 
        {
            RuleFor(x => x.Status)
            .NotEmpty().WithMessage("Status is required.")
            .Must(BeValidStatus).WithMessage("Status must be 'on rent' or 'on sale'.");
        }
        private bool BeValidStatus(string status)
        {
            return status == "on rent" || status == "on sale";
        }
    }
}

