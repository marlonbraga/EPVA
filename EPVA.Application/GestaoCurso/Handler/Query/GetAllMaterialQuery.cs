using EPVA.Application.GestaoCurso.Dto;
using MediatR;

namespace EPVA.Application.GestaoCurso.Handler.Query
{
    public class GetAllMaterialQuery : IRequest<GetAllMaterialQueryResponse>
    {

    }

    public class GetAllMaterialQueryResponse
    {
        public IList<MaterialOutputDto> Materials { get; set; }

        public GetAllMaterialQueryResponse(IList<MaterialOutputDto> materiais)
        {
            Materials = materiais;
        }
    }
}
