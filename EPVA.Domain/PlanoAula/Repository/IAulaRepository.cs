using EPVA.CrossCutting.Repository;

namespace EPVA.Domain.PlanoAula.Repository
{
    public interface IAulaRepository : IRepository<Aula>
    {
        Task<IEnumerable<Material>> ObterTodosMateriais();
    }
}
