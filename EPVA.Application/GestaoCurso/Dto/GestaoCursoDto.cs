using EPVA.Application.PlanoAula.Dto;
using System.ComponentModel.DataAnnotations;

namespace EPVA.Application.GestaoCurso.Dto
{
    public record ModuloInputDto(string Nome, List<AulaInputDto> Aulas);
    public record ModuloOutputDto(Guid Id, string Nome, List<AulaOutputDto> Aulas, List<MaterialOutputDto> Materiais);
    public record AulaInputDto(string Nome, List<MaterialInputDto> Materiais);
    public record AulaOutputDto(Guid Id, string Nome, List<MaterialOutputDto> Materiais);
    public record MaterialInputDto(
                [Required(ErrorMessage = "Nome é obrigatório")] string Nome,
                [Required(ErrorMessage = "Email é obrigatório")] string Backdrop);
    public record MaterialOutputDto(Guid Id, string Nome, string Backdrop);
}