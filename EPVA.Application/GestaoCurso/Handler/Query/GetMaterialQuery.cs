using EPVA.Application.GestaoCurso.Dto;
using MediatR;

namespace EPVA.Application.GestaoCurso.Handler.Query
{
    public class GetMaterialQuery : IRequest<GetMaterialQueryResponse>
    {
        public Guid IdMaterial { get; set; }

        public GetMaterialQuery(Guid idMaterial)
        {
            IdMaterial = idMaterial;
        }
    }

    public class GetMaterialQueryResponse
    {
        public MaterialOutputDto Material { get; set; }

        public GetMaterialQueryResponse(MaterialOutputDto material)
        {
            Material = material;
        }
    }
}
