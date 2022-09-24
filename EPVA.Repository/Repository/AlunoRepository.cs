using EPVA.Domain.GestaoCurso;
using EPVA.Domain.GestaoCurso.Repository;
using EPVA.Repository.Context;
using EPVA.Repository.Database;

namespace EPVA.Repository.Repository
{
    public class AlunoRepository : Repository<Aluno>, IAlunoRepository
    {
        public AlunoRepository(EPVAContext context) : base(context)
        {

        }
    }
}
