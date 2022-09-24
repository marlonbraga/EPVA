using EPVA.Application.GestaoCurso.Dto;
using MediatR;

namespace EPVA.Application.GestaoCurso.Handler.Query
{
    public class GetAllAulaQuery : IRequest<GetAllAulaQueryResponse>
    {

    }

    public class GetAllAulaQueryResponse
    {
        public IList<AulaOutputDto> Aulas { get; set; }

        public GetAllAulaQueryResponse(IList<AulaOutputDto> aulas)
        {
            Aulas = aulas;
        }
    }
}
