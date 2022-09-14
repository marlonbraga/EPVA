using FluentValidation;
using EPVA.Domain.Account.Interface;

namespace EPVA.Domain.GestaoCurso.Rules
{
    public class UsuarioValidator : AbstractValidator<IUsuario>
    {
        public UsuarioValidator()
        {
            RuleFor(x => x.Nome).NotEmpty();
            RuleFor(x => x.Email).SetValidator(new EmailValidator());
            RuleFor(x => x.Password).SetValidator(new PasswordValidator());
        }
    }
}
