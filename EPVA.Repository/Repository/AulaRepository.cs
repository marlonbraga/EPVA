using EPVA.Domain.PlanoAula;
using EPVA.Domain.PlanoAula.Repository;
using EPVA.Repository.Context;
using EPVA.Repository.Database;
using Microsoft.EntityFrameworkCore;

namespace EPVA.Repository.Repository
{
    public class AulaRepository : Repository<Aula>, IAulaRepository
    {
        public AulaRepository(EPVAContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Material>> ObterTodosMateriais()
        {
            return (IEnumerable<Material>)await Query.Include(x => x.Materiais).ToListAsync();
        }
    }
}
