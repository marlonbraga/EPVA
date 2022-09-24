using EPVA.Application.PlanoAula.Dto;
using MediatR;

namespace EPVA.Application.PlanoAula.Handler.Query
{
    public class GetClasseQuery : IRequest<GetClasseQueryResponse>
    {
        public Guid IdClasse { get; set; }

        public GetClasseQuery(Guid idClasse)
        {
            IdClasse = idClasse;
        }
    }

    public class GetClasseQueryResponse
    {
        public ClasseOutputDto Classe { get; set; }

        public GetClasseQueryResponse(ClasseOutputDto classe)
        {
            Classe = classe;
        }
    }
}
