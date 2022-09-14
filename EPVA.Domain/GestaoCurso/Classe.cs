using EPVA.CrossCutting.Entity;
using EPVA.Domain.Curso;

namespace EPVA.Domain.GestaoCurso
{
    public class Classe : Entity<Guid>
    {
        public Modulo Modulo { get; set; }
        public Professor Professor { get; set; }
        public virtual IList<Aluno> Alunos { get; set; }
    }
}
