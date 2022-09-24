using EPVA.Domain.GestaoCurso;
using EPVA.Domain.GestaoCurso.Repository;
using EPVA.Repository.Context;
using EPVA.Repository.Database;

namespace EPVA.Repository.Repository
{
    public class ClasseRepository : Repository<Classe>, IClasseRepository
    {
        public ClasseRepository(EPVAContext context) : base(context)
        {

        }
    }
}
