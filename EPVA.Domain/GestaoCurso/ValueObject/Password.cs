namespace EPVA.Domain.GestaoCurso.ValueObject
{
    public class Password
    {
        public Password()
        {

        }
        public Password(string valor)
        {
            Valor = valor ?? throw new ArgumentNullException(nameof(Password));
        }

        public string Valor { get; set; }
    }
}
