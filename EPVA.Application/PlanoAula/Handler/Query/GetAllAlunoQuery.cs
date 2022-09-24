using EPVA.Application.PlanoAula.Dto;
using MediatR;

namespace EPVA.Application.PlanoAula.Handler.Query
{
    public class GetAllAlunoQuery : IRequest<GetAllAlunoQueryResponse>
    {

    }

    public class GetAllAlunoQueryResponse
    {
        public IList<AlunoOutputDto> Alunos { get; set; }

        public GetAllAlunoQueryResponse(IList<AlunoOutputDto> alunos)
        {
            Alunos = alunos;
        }
    }
}
