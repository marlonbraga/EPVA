using EPVA.Application.PlanoAula.Dto;
using MediatR;

namespace EPVA.Application.PlanoAula.Handler.Command
{
    public class EditAlunoCommand : IRequest<EditAlunoCommandResponse>
    {
        public AlunoInputDto Aluno { get; set; }

        public Guid IdAluno { get; set; }

        public EditAlunoCommand(Guid idAluno, AlunoInputDto aluno)
        {
            IdAluno = idAluno;
            Aluno = aluno;
        }
    }

    public class EditAlunoCommandResponse
    {
        public AlunoOutputDto Aluno { get; set; }

        public EditAlunoCommandResponse(AlunoOutputDto aluno)
        {
            Aluno = aluno;
        }
    }
}
