using EPVA.CrossCutting.Entity;
using EPVA.Domain.GestaoCurso;

namespace EPVA.Domain.PlanoAula
{
    public class Modulo : Entity<Guid>
    {
        public string Nome { get; set; }
        public virtual IList<Aula> Aulas { get; set; }
        public virtual IList<Material> Materiais { get; set; }
        public virtual IList<Classe> Classes { get; set; }
    }
}
