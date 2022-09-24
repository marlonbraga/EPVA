using EPVA.CrossCutting.Entity;

namespace EPVA.Domain.PlanoAula
{
    public class Material : Entity<Guid>
    {
        public string Nome { get; set; }
        public string Backdrop { get; set; }
    }
}
