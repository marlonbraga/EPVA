using MediatR;

namespace EPVA.Application.GestaoCurso.Handler.Command
{
    public class DeleteModuloCommand : IRequest<DeleteModuloCommandResponse>
    {
        public Guid IdModulo { get; set; }

        public DeleteModuloCommand(Guid idModulo)
        {
            IdModulo = idModulo;
        }
    }

    public class DeleteModuloCommandResponse
    {

    }
}
