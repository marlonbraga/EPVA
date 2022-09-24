using MediatR;

namespace EPVA.Application.GestaoCurso.Handler.Command
{
    public class DeleteAulaCommand : IRequest<DeleteAulaCommandResponse>
    {
        public Guid IdAula { get; set; }

        public DeleteAulaCommand(Guid idAula)
        {
            IdAula = idAula;
        }
    }

    public class DeleteAulaCommandResponse
    {

    }
}
