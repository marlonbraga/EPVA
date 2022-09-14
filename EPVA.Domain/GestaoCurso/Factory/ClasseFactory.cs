namespace EPVA.Domain.GestaoCurso.Factory
{
    public static class ClasseFactory
    {
        public static Classe Create(string nome, Aluno aluno)
        {
            if (aluno == null)
                throw new ArgumentNullException("Para criar uma classe a classe deve ter no minimo um aluno");

            return new Classe()
            {
                Alunos = new List<Aluno>() { aluno }
            };
        }

        public static Classe Create(string nome, IEnumerable<Aluno> alunos)
        {
            if (!alunos.Any())
                throw new ArgumentNullException("Para criar uma classe, a classe deve ter no minimo um aluno");

            return new Classe()
            {
                Alunos = alunos.ToList()
            };

        }
    }
}
