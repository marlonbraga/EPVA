using EPVA.Application.PlanoAula.Dto;
using MediatR;

namespace EPVA.Application.PlanoAula.Handler.Command
{
    public class CreateClasseCommand : IRequest<CreateClasseCommandResponse>
    {
        public ClasseInputDto Classe { get; set; }

        public CreateClasseCommand(ClasseInputDto classe)
        {
            Classe = classe;
        }
    }

    public class CreateClasseCommandResponse
    {
        public ClasseOutputDto Classe { get; set; }

        public CreateClasseCommandResponse(ClasseOutputDto classe)
        {
            Classe = classe;
        }
    }
}
