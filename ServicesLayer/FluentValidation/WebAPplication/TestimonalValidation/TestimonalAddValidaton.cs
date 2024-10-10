﻿using EntityLayer.WebApplication.ViewModels.Testimonal;
using ServiceLayer.Messages.WebApplication;
using FluentValidation;

namespace ServiceLayer.FluentValidation.WebAPplication.TestimonalValidation
{
    public class TestimonalAddValidaton : AbstractValidator<TestimonalAddVM>
    {
        public TestimonalAddValidaton()
        {
            RuleFor(x => x.FullName)
               .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("FullName"))
               .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("FullName"))
               .MaximumLength(100).WithMessage(ValidationMessages.MaximumCharachterAllowence("FullName", 100));
            RuleFor(x => x.Title)
               .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("Title"))
               .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("Title"))
               .MaximumLength(100).WithMessage(ValidationMessages.MaximumCharachterAllowence("Title", 100));
            RuleFor(x => x.Comment)
               .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("Comment"))
               .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("Comment"))
               .MaximumLength(2000).WithMessage(ValidationMessages.MaximumCharachterAllowence("Comment", 2000)); ;

            RuleFor(x => x.Photo)
              .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("Photo"))
              .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("Photo"));
        }
    }
}
