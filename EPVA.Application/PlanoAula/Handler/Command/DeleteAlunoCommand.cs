using MediatR;

namespace EPVA.Application.PlanoAula.Handler.Command
{
    public class DeleteAlunoCommand : IRequest<DeleteAlunoCommandResponse>
    {
        public Guid IdAluno { get; set; }

        public DeleteAlunoCommand(Guid idAluno)
        {
            IdAluno = idAluno;
        }
    }

    public class DeleteAlunoCommandResponse
    {

    }
}
