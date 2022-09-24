using MediatR;

namespace EPVA.Application.PlanoAula.Handler.Command
{
    public class DeleteProfessorCommand : IRequest<DeleteProfessorCommandResponse>
    {
        public Guid IdProfessor { get; set; }

        public DeleteProfessorCommand(Guid idProfessor)
        {
            IdProfessor = idProfessor;
        }
    }

    public class DeleteProfessorCommandResponse
    {

    }
}
