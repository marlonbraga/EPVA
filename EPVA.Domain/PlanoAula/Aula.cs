using EPVA.CrossCutting.Entity;
using EPVA.Domain.Curso;

namespace EPVA.Domain.PlanoAula
{
    public class Aula : Entity<Guid>
    {
        public string Nome { get; set; }
        public Modulo Modulo { get; set; }
        public virtual IList<Material> Materials { get; set; }

    }
}
