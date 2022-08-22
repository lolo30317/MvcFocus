using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validation.FluentValidation
{
    public class CategoryValidation:AbstractValidator<Category>
    {
        public CategoryValidation()
        {
            RuleFor(c => c.CategoryName).NotEmpty().WithMessage("Category cannot be null");
            RuleFor(c => c.CategoryDescription).NotEmpty().WithMessage("Description cannot be null");
            RuleFor(c => c.CategoryName).MinimumLength(3).WithMessage("Cannot lower than 3 character");
            RuleFor(c => c.CategoryName).MaximumLength(20).WithMessage("Cannot higher than 20 character");
        }
    }
}
