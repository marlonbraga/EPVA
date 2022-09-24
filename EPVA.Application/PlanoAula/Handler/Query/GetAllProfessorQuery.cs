using EPVA.Application.PlanoAula.Dto;
using MediatR;

namespace EPVA.Application.PlanoAula.Handler.Query
{
    public class GetAllProfessorQuery : IRequest<GetAllProfessorQueryResponse>
    {

    }

    public class GetAllProfessorQueryResponse
    {
        public IList<ProfessorOutputDto> Professors { get; set; }

        public GetAllProfessorQueryResponse(IList<ProfessorOutputDto> professores)
        {
            Professors = professores;
        }
    }
}
