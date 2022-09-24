using EPVA.Application.PlanoAula.Dto;
using MediatR;

namespace EPVA.Application.PlanoAula.Handler.Query
{
    public class GetAlunoQuery : IRequest<GetAlunoQueryResponse>
    {
        public Guid IdAluno { get; set; }

        public GetAlunoQuery(Guid idAluno)
        {
            IdAluno = idAluno;
        }
    }

    public class GetAlunoQueryResponse
    {
        public AlunoOutputDto Aluno { get; set; }

        public GetAlunoQueryResponse(AlunoOutputDto aluno)
        {
            Aluno = aluno;
        }
    }
}
