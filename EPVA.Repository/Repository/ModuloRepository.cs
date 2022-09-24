using EPVA.Domain.PlanoAula;
using EPVA.Domain.PlanoAula.Repository;
using EPVA.Repository.Context;
using EPVA.Repository.Database;

namespace EPVA.Repository.Repository
{
    public class ModuloRepository : Repository<Modulo>, IModuloRepository
    {
        public ModuloRepository(EPVAContext context) : base(context)
        {

        }
    }
}
