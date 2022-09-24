using MediatR;

namespace EPVA.Application.PlanoAula.Handler.Command
{
    public class DeleteClasseCommand : IRequest<DeleteClasseCommandResponse>
    {
        public Guid IdClasse { get; set; }

        public DeleteClasseCommand(Guid idClasse)
        {
            IdClasse = idClasse;
        }
    }

    public class DeleteClasseCommandResponse
    {

    }
}
