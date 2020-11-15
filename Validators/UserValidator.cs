
using FluentValidation;

public class UserValidator : AbstractValidator<User>
{
    public UserValidator()
    {
        RuleFor(user => user.Name).NotNull().WithMessage("Ad alanı boş olamaz");
        RuleFor(user => user.Surname).NotNull().WithMessage("Soyad alanı boş olamaz");
    }
}