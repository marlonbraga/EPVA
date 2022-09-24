using EPVA.Application.PlanoAula.Dto;

namespace EPVA.Application.PlanoAula.Service
{
    public interface IClasseService
    {
        Task<ClasseOutputDto> Criar(ClasseInputDto dto);
        Task<List<ClasseOutputDto>> ObterTodos();
        Task<ClasseOutputDto> Obter(Guid id);
        Task<ClasseOutputDto> Editar(Guid id, ClasseInputDto dto);
        Task<ClasseOutputDto> Deletar(Guid id);
    }
}