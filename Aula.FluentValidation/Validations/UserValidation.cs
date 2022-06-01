using FluentValidation;

namespace Aula.FluentValidation.Validations
{
    public class UserValidation : AbstractValidator<UserRequest>
    {
        public UserValidation()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .WithMessage("Nome não pode ser vazio")
                .Length(10, 20);

            RuleFor(p => p.Email)
                .NotEmpty()
                .EmailAddress();

            RuleFor(p => p.Age)
                .NotEmpty();

            RuleFor(p => p)
                .Must(BeValid)
                .WithMessage("Idade deve ser maior ou igual a 18 anos");
        }

        private bool BeValid(UserRequest user)
        {
            //conectar no repositorio

            if (user.Age < 18)
            {
                return false;
            }

            return true;
        }
    }
}
