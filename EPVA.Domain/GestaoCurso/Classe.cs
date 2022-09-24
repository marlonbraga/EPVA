using EPVA.CrossCutting.Entity;
using EPVA.Domain.PlanoAula;

namespace EPVA.Domain.GestaoCurso
{
    public class Classe : Entity<Guid>
    {
        public virtual Modulo Modulo { get; set; }
        public virtual Professor Professor { get; set; }
        public virtual IList<Aluno> Alunos { get; set; }
    }
}
