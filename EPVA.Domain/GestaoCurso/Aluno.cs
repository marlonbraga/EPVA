using EPVA.CrossCutting.Entity;
using EPVA.Domain.GestaoCurso.Interface;
using EPVA.Domain.GestaoCurso.ValueObject;

namespace EPVA.Domain.GestaoCurso
{
    public class Aluno : Entity<Guid>, IUsuario
    {
        public string Nome { get; set; }
        public virtual Email? Email { get; set; }
        public virtual Password? Password { get; set; }
    }
}
