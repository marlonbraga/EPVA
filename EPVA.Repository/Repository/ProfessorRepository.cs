using EPVA.Domain.Album;
using EPVA.Domain.Album.Repository;
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
