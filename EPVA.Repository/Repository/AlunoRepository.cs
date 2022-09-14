using EPVA.Domain.Album;
using EPVA.Domain.Album.Repository;
using EPVA.Repository.Context;
using EPVA.Repository.Database;

namespace EPVA.Repository.Repository
{
    public class AlunoRepository : Repository<Aluno>, IAlunoRepository
    {
        public AlunoRepository(EPVAContext context) : base(context)
        {

        }
    }
}
