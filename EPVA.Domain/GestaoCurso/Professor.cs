using EPVA.CrossCutting.Entity;
using EPVA.Domain.Account.Interface;
using EPVA.Domain.Account.ValueObject;

namespace EPVA.Domain.GestaoCurso
{
    public class Professor : Entity<Guid>, IUsuario
    {
        public string Nome { get; set; }
        public Email Email { get; set; }
        public Password Password { get; set; }
        public virtual IList<Classe> Classes { get; set; }
    }
}
