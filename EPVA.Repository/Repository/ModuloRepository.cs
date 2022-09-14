using EPVA.Domain.Album;
using EPVA.Domain.Album.Repository;
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
