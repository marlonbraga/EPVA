using EPVA.Application.PlanoAula.Dto;
using MediatR;

namespace EPVA.Application.PlanoAula.Handler.Query
{
    public class GetProfessorQuery : IRequest<GetProfessorQueryResponse>
    {
        public Guid IdProfessor { get; set; }

        public GetProfessorQuery(Guid idProfessor)
        {
            IdProfessor = idProfessor;
        }
    }

    public class GetProfessorQueryResponse
    {
        public ProfessorOutputDto Professor { get; set; }

        public GetProfessorQueryResponse(ProfessorOutputDto professor)
        {
            Professor = professor;
        }
    }
}
