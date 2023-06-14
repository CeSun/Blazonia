using FluentValidation;

namespace ValidationsSample.Models;

public class LogInModelValidator : AbstractValidator<LogInModel>
{
    public LogInModelValidator()
    {
        RuleFor(m => m.Email)
            .NotNull()
            .EmailAddress();

        RuleFor(m => m.Password)
            .NotNull()
            .Length(8, 16);

        RuleFor(m => m.ConfirmPassword)
            .NotNull()
            .Equal(m => m.Password)
            .WithMessage("'{PropertyName}' should be equal to '{ComparisonProperty}'");
    }
}