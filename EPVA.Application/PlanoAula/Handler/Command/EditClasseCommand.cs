using EPVA.Application.PlanoAula.Dto;
using MediatR;

namespace EPVA.Application.PlanoAula.Handler.Command
{
    public class EditClasseCommand : IRequest<EditClasseCommandResponse>
    {
        public ClasseInputDto Classe { get; set; }

        public Guid IdClasse { get; set; }

        public EditClasseCommand(Guid idClasse, ClasseInputDto classe)
        {
            IdClasse = idClasse;
            Classe = classe;
        }
    }

    public class EditClasseCommandResponse
    {
        public ClasseOutputDto Classe { get; set; }

        public EditClasseCommandResponse(ClasseOutputDto classe)
        {
            Classe = classe;
        }
    }
}
