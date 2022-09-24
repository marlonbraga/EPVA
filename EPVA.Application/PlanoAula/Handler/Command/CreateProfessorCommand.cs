using EPVA.Application.PlanoAula.Dto;
using MediatR;

namespace EPVA.Application.PlanoAula.Handler.Command
{
    public class CreateProfessorCommand : IRequest<CreateProfessorCommandResponse>
    {
        public ProfessorInputDto Professor { get; set; }

        public CreateProfessorCommand(ProfessorInputDto professor)
        {
            Professor = professor;
        }
    }

    public class CreateProfessorCommandResponse
    {
        public ProfessorOutputDto Professor { get; set; }

        public CreateProfessorCommandResponse(ProfessorOutputDto professor)
        {
            Professor = professor;
        }
    }
}
