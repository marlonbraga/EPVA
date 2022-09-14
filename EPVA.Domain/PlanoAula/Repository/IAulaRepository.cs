using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPVA.Domain.Curso;

namespace EPVA.Domain.PlanoAula.Repository
{
    public interface IAulaRepository : IRepository<Aula>
    {
        Task<IEnumerable<Material>> ObterTodosMateriais();
    }
}
