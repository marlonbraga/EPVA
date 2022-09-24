using EPVA.Application.GestaoCurso.Dto;
using MediatR;

namespace EPVA.Application.GestaoCurso.Handler.Command
{
    public class EditMaterialCommand : IRequest<EditMaterialCommandResponse>
    {
        public MaterialInputDto Material { get; set; }

        public Guid IdMaterial { get; set; }

        public EditMaterialCommand(Guid idMaterial, MaterialInputDto material)
        {
            IdMaterial = idMaterial;
            Material = material;
        }
    }

    public class EditMaterialCommandResponse
    {
        public MaterialOutputDto Material { get; set; }

        public EditMaterialCommandResponse(MaterialOutputDto material)
        {
            Material = material;
        }
    }
}
