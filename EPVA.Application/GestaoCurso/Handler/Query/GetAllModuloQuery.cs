using EPVA.Application.GestaoCurso.Dto;
using MediatR;

namespace EPVA.Application.GestaoCurso.Handler.Query
{
    public class GetAllModuloQuery : IRequest<GetAllModuloQueryResponse>
    {

    }

    public class GetAllModuloQueryResponse
    {
        public IList<ModuloOutputDto> Modulos { get; set; }

        public GetAllModuloQueryResponse(IList<ModuloOutputDto> modulos)
        {
            Modulos = modulos;
        }
    }
}
