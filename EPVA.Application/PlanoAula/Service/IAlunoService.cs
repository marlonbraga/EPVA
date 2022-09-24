using EPVA.Application.PlanoAula.Dto;

namespace EPVA.Application.PlanoAula.Service
{
    public interface IAlunoService
    {
        Task<AlunoOutputDto> Criar(AlunoInputDto dto);
        Task<List<AlunoOutputDto>> ObterTodos();
        Task<AlunoOutputDto> Obter(Guid id);
        Task<AlunoOutputDto> Editar(Guid id, AlunoInputDto dto);
        Task<AlunoOutputDto> Deletar(Guid id);
    }
}