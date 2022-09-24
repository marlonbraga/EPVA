using MediatR;

namespace EPVA.Application.GestaoCurso.Handler.Command
{
    public class DeleteMaterialCommand : IRequest<DeleteMaterialCommandResponse>
    {
        public Guid IdMaterial { get; set; }

        public DeleteMaterialCommand(Guid idMaterial)
        {
            IdMaterial = idMaterial;
        }
    }

    public class DeleteMaterialCommandResponse
    {

    }
}
