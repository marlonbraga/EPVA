using EPVA.Application.GestaoCurso.Dto;
using MediatR;

namespace EPVA.Application.GestaoCurso.Handler.Command
{
    public class EditAulaCommand : IRequest<EditAulaCommandResponse>
    {
        public AulaInputDto Aula { get; set; }

        public Guid IdAula { get; set; }

        public EditAulaCommand(Guid idAula, AulaInputDto aula)
        {
            IdAula = idAula;
            Aula = aula;
        }
    }

    public class EditAulaCommandResponse
    {
        public AulaOutputDto Aula { get; set; }

        public EditAulaCommandResponse(AulaOutputDto aula)
        {
            Aula = aula;
        }
    }
}
