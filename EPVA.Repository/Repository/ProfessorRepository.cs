using EPVA.Domain.GestaoCurso;
using EPVA.Domain.GestaoCurso.Repository;
using EPVA.Repository.Context;
using EPVA.Repository.Database;

namespace EPVA.Repository.Repository
{
    public class ProfessorRepository : Repository<Professor>, IProfessorRepository
    {
        public ProfessorRepository(EPVAContext context) : base(context)
        {

        }
    }
}
