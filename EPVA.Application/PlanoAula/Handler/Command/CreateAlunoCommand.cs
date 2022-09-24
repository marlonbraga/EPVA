using EPVA.Application.PlanoAula.Dto;
using MediatR;

namespace EPVA.Application.PlanoAula.Handler.Command
{
    public class CreateAlunoCommand : IRequest<CreateAlunoCommandResponse>
    {
        public AlunoInputDto Aluno { get; set; }

        public CreateAlunoCommand(AlunoInputDto aluno)
        {
            Aluno = aluno;
        }
    }

    public class CreateAlunoCommandResponse
    {
        public AlunoOutputDto Aluno { get; set; }

        public CreateAlunoCommandResponse(AlunoOutputDto aluno)
        {
            Aluno = aluno;
        }
    }
}
