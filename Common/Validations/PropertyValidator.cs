using Common.DTOs.Property;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Validations
{
    public class PropertyValidator:AbstractValidator<PropertyDto>
    {
        public PropertyValidator() 
        {
            RuleFor(c => c.Status).NotNull().NotEmpty().WithMessage("Password is required")
                .Equal("on rent").Equal("on sale").WithMessage("Status must be equal to 'on sale' or 'on rent'");                
        }
    }
}
