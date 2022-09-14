using EPVA.Domain.Album;
using EPVA.Domain.Album.Repository;
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
