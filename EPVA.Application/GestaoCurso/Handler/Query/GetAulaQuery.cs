using EPVA.Application.GestaoCurso.Dto;
using MediatR;

namespace EPVA.Application.GestaoCurso.Handler.Query
{
    public class GetAulaQuery : IRequest<GetAulaQueryResponse>
    {
        public Guid IdAula { get; set; }

        public GetAulaQuery(Guid idAula)
        {
            IdAula = idAula;
        }
    }

    public class GetAulaQueryResponse
    {
        public AulaOutputDto Aula { get; set; }

        public GetAulaQueryResponse(AulaOutputDto aula)
        {
            Aula = aula;
        }
    }
}
