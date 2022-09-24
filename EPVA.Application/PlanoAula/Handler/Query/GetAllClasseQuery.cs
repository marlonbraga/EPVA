using EPVA.Application.PlanoAula.Dto;
using MediatR;

namespace EPVA.Application.PlanoAula.Handler.Query
{
    public class GetAllClasseQuery : IRequest<GetAllClasseQueryResponse>
    {

    }

    public class GetAllClasseQueryResponse
    {
        public IList<ClasseOutputDto> Classes { get; set; }

        public GetAllClasseQueryResponse(IList<ClasseOutputDto> classes)
        {
            Classes = classes;
        }
    }
}
