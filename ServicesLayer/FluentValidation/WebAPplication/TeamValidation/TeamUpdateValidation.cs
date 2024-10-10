using EntityLayer.WebApplication.ViewModels.Team;
using ServiceLayer.Messages.WebApplication;
using FluentValidation;
namespace ServiceLayer.FluentValidation.WebAPplication.TeamValidation
{
    public class TeamUpdateValidation : AbstractValidator<TeamUpdateVM>
    {
        public TeamUpdateValidation()
        {
            RuleFor(x => x.FullName)
              .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("FullName"))
              .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("FullName"))
              .MaximumLength(100).WithMessage(ValidationMessages.MaximumCharachterAllowence("FullName", 100));
            RuleFor(x => x.Title)
               .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("Title"))
               .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("Title"))
               .MaximumLength(100).WithMessage(ValidationMessages.MaximumCharachterAllowence("Title", 100));

        }
    }
}
