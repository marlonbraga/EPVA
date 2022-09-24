using EPVA.Application.PlanoAula.Dto;

namespace EPVA.Application.PlanoAula.Service
{
    public interface IProfessorService
    {
        Task<ProfessorOutputDto> Criar(ProfessorInputDto dto);
        Task<List<ProfessorOutputDto>> ObterTodos();
        Task<ProfessorOutputDto> Obter(Guid id);
        Task<ProfessorOutputDto> Editar(Guid id, ProfessorInputDto dto);
        Task<ProfessorOutputDto> Deletar(Guid id);
    }
}