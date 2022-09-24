using EPVA.Application.GestaoCurso.Dto;

namespace EPVA.Application.GestaoCurso.Service
{
    public interface IMaterialService
    {
        Task<MaterialOutputDto> Criar(MaterialInputDto dto);
        Task<List<MaterialOutputDto>> ObterTodos();
        Task<MaterialOutputDto> Obter(Guid id);
        Task<MaterialOutputDto> Editar(Guid id, MaterialInputDto dto);
        Task<MaterialOutputDto> Deletar(Guid id);
    }
}