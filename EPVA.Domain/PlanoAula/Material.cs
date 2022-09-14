using EPVA.CrossCutting.Entity;
using EPVA.Domain.Curso;

namespace EPVA.Domain.PlanoAula
{
    public class Material : Entity<Guid>
    {
        public string Nome { get; set; }
        public virtual IList<Aula> Aulas { get; set; }
        public virtual IList<Modulo> Modulos { get; set; }
    }
}
