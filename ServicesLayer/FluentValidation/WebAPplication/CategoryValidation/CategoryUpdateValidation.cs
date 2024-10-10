﻿using EntityLayer.WebApplication.ViewModels.Category;
using ServiceLayer.Messages.WebApplication;
using FluentValidation;
namespace ServiceLayer.FluentValidation.WebAPplication.CategoryValidation
{
    public class CategoryUpdateValidation : AbstractValidator<CategoryUpdateVM>
    {
        public CategoryUpdateValidation()
        {
            RuleFor(x => x.Name)
               .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("Name"))
               .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("Name"))
               .MaximumLength(50).WithMessage(ValidationMessages.MaximumCharachterAllowence("Name", 50));
        }
    }
}
