using EPVA.Domain.GestaoCurso.ValueObject;

namespace EPVA.Domain.GestaoCurso.Interface
{
    public interface IUsuario
    {
        public string Nome { get; set; }
        public Email Email { get; set; }
        public Password Password { get; set; }
    }
}
