using EPVA.Domain.Account.ValueObject;

namespace EPVA.Domain.GestaoCurso.Interface
{
    internal interface IUsuario
    {
        public string Nome { get; set; }
        public Email Email { get; set; }
        public Password Password { get; set; }
    }
}
