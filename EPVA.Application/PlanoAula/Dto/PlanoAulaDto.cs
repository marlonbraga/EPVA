using EPVA.Application.GestaoCurso.Dto;
using System.ComponentModel.DataAnnotations;

namespace EPVA.Application.PlanoAula.Dto
{
    public record AlunoInputDto(string Nome, string Email, string Password);
    public record AlunoOutputDto(Guid Id, string Nome, string Email, string Password);
    public record ClasseInputDto(ModuloInputDto Modulo, ProfessorInputDto Professor, List<AlunoInputDto> Alunos);
    public record ClasseOutputDto(Guid Id, ModuloOutputDto Modulo, ProfessorOutputDto Professor, List<AlunoOutputDto> Alunos);
    public record ProfessorInputDto(
                [Required(ErrorMessage = "Nome é obrigatório")] string Nome,
                [Required(ErrorMessage = "Email é obrigatório")] string Email,
                [Required(ErrorMessage = "Password é obrigatório")] string Password);
    public record ProfessorOutputDto(Guid Id, string Nome, string Email, string Password);
}