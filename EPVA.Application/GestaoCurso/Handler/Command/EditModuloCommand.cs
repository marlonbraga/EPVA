using EPVA.Application.GestaoCurso.Dto;
using MediatR;

namespace EPVA.Application.GestaoCurso.Handler.Command
{
    public class EditModuloCommand : IRequest<EditModuloCommandResponse>
    {
        public ModuloInputDto Modulo { get; set; }

        public Guid IdModulo { get; set; }

        public EditModuloCommand(Guid idModulo, ModuloInputDto modulo)
        {
            IdModulo = idModulo;
            Modulo = modulo;
        }
    }

    public class EditModuloCommandResponse
    {
        public ModuloOutputDto Modulo { get; set; }

        public EditModuloCommandResponse(ModuloOutputDto modulo)
        {
            Modulo = modulo;
        }
    }
}
