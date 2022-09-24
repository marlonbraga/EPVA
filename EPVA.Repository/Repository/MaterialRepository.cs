using EPVA.Domain.PlanoAula;
using EPVA.Domain.PlanoAula.Repository;
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
