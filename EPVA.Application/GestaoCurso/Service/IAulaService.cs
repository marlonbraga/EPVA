using EPVA.Application.GestaoCurso.Dto;

namespace EPVA.Application.GestaoCurso.Service
{
    public interface IAulaService
    {
        Task<AulaOutputDto> Criar(AulaInputDto dto);
        Task<List<AulaOutputDto>> ObterTodos();
        Task<AulaOutputDto> Obter(Guid id);
        Task<AulaOutputDto> Editar(Guid id, AulaInputDto dto);
        Task<AulaOutputDto> Deletar(Guid id);
    }
}