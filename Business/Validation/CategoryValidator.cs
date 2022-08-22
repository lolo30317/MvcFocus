using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validation
{
    public class CategoryValidator:AbstractValidator<Category>
    {

        public CategoryValidator()
        {
            RuleFor(c => c.CategoryName).NotEmpty().WithMessage("Category Name cannot be null");
            RuleFor(c => c.CategoryName).MinimumLength(3).WithMessage("Category Name cannot be lower than 3");
            RuleFor(c => c.CategoryName).NotEmpty().WithMessage("Category name cannot be higher than 20");
            RuleFor(c => c.CategoryDescription).NotEmpty().WithMessage("Category Description cannot be null");
        }
    }

}
