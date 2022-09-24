using EPVA.Application.GestaoCurso.Dto;
using MediatR;

namespace EPVA.Application.GestaoCurso.Handler.Command
{
    public class CreateMaterialCommand : IRequest<CreateMaterialCommandResponse>
    {
        public MaterialInputDto Material { get; set; }

        public CreateMaterialCommand(MaterialInputDto material)
        {
            Material = material;
        }
    }

    public class CreateMaterialCommandResponse
    {
        public MaterialOutputDto Material { get; set; }

        public CreateMaterialCommandResponse(MaterialOutputDto material)
        {
            Material = material;
        }
    }
}
