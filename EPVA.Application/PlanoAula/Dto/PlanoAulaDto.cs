using EPVA.Application.GestaoCurso.Dto;
using EPVA.Domain.GestaoCurso;
using System.ComponentModel.DataAnnotations;

namespace EPVA.Application.PlanoAula.Dto
{
    public record AlunoInputDto(string Nome, string Email, string Password, List<Guid> Classes);
    public record AlunoOutputDto(Guid Id, string Nome, string Email, string Password, List<ClasseOutputDto> Classes);
    public record ClasseInputDto(Guid Modulo, Guid Professor, List<Guid> Alunos);
    public record ClasseOutputDto(Guid Id, ModuloOutputDto Modulo, ProfessorOutputDto Professor, List<AlunoOutputDto> Alunos);
    public record ProfessorInputDto(
                [Required(ErrorMessage = "Nome é obrigatório")] string Nome,
                [Required(ErrorMessage = "Email é obrigatório")] string Email,
                [Required(ErrorMessage = "Password é obrigatório")] string Password);
    public record ProfessorOutputDto(Guid Id, string Nome, string Email, string Password, List<ClasseOutputDto> Classes);
}