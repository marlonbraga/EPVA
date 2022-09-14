using EPVA.Domain.Album;
using EPVA.Domain.Album.Repository;
using EPVA.Repository.Context;
using EPVA.Repository.Database;

namespace EPVA.Repository.Repository
{
    public class MaterialRepository : Repository<Material>, IMaterialRepository
    {
        public MaterialRepository(EPVAContext context) : base(context)
        {

        }
    }
}
