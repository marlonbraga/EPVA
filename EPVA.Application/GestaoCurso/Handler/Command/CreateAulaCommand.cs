using EPVA.Application.GestaoCurso.Dto;
using MediatR;

namespace EPVA.Application.GestaoCurso.Handler.Command
{
    public class CreateAulaCommand : IRequest<CreateAulaCommandResponse>
    {
        public AulaInputDto Aula { get; set; }

        public CreateAulaCommand(AulaInputDto album)
        {
            Aula = album;
        }
    }

    public class CreateAulaCommandResponse
    {
        public AulaOutputDto Aula { get; set; }

        public CreateAulaCommandResponse(AulaOutputDto album)
        {
            Aula = album;
        }
    }
}
