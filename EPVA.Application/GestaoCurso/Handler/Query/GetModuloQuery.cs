using EPVA.Application.GestaoCurso.Dto;
using MediatR;

namespace EPVA.Application.GestaoCurso.Handler.Query
{
    public class GetModuloQuery : IRequest<GetModuloQueryResponse>
    {
        public Guid IdModulo { get; set; }

        public GetModuloQuery(Guid idModulo)
        {
            IdModulo = idModulo;
        }
    }

    public class GetModuloQueryResponse
    {
        public ModuloOutputDto Modulo { get; set; }

        public GetModuloQueryResponse(ModuloOutputDto modulo)
        {
            Modulo = modulo;
        }
    }
}
