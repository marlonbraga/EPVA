using EPVA.Application.GestaoCurso.Dto;

namespace EPVA.Application.GestaoCurso.Service
{
    public interface IModuloService
    {
        Task<ModuloOutputDto> Criar(ModuloInputDto dto);
        Task<List<ModuloOutputDto>> ObterTodos();
        Task<ModuloOutputDto> Obter(Guid id);
        Task<ModuloOutputDto> Editar(Guid id, ModuloInputDto dto);
        Task<ModuloOutputDto> Deletar(Guid id);
    }
}