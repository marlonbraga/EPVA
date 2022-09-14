using EPVA.Domain.Album;
using EPVA.Domain.Album.Repository;
using EPVA.Repository.Context;
using EPVA.Repository.Database;

namespace EPVA.Repository.Repository
{
    public class AulaRepository : Repository<Aula>, IAulaRepository
    {
        public AulaRepository(EPVAContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Material>> ObterTodosMateriais()
        {
            return await this.Query.Include(x => x.Materiais).ToListAsync();
        }
    }
}
