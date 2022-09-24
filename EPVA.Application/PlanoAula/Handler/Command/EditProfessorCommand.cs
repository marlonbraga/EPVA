using EPVA.Application.PlanoAula.Dto;
using MediatR;

namespace EPVA.Application.PlanoAula.Handler.Command
{
    public class EditProfessorCommand : IRequest<EditProfessorCommandResponse>
    {
        public ProfessorInputDto Professor { get; set; }

        public Guid IdProfessor { get; set; }

        public EditProfessorCommand(Guid idProfessor, ProfessorInputDto professor)
        {
            IdProfessor = idProfessor;
            Professor = professor;
        }
    }

    public class EditProfessorCommandResponse
    {
        public ProfessorOutputDto Professor { get; set; }

        public EditProfessorCommandResponse(ProfessorOutputDto professor)
        {
            Professor = professor;
        }
    }
}
