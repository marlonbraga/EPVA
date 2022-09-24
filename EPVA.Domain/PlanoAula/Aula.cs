using EPVA.CrossCutting.Entity;

namespace EPVA.Domain.PlanoAula
{
    public class Aula : Entity<Guid>
    {
        public string Nome { get; set; }
        public virtual Modulo Modulo { get; set; }
        public virtual IList<Material> Materiais { get; set; }

    }
}
