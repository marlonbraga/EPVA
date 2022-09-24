using EPVA.Application.GestaoCurso.Dto;
using MediatR;

namespace EPVA.Application.GestaoCurso.Handler.Command
{
    public class CreateModuloCommand : IRequest<CreateModuloCommandResponse>
    {
        public ModuloInputDto Modulo { get; set; }

        public CreateModuloCommand(ModuloInputDto modulo)
        {
            Modulo = modulo;
        }
    }

    public class CreateModuloCommandResponse
    {
        public ModuloOutputDto Modulo { get; set; }

        public CreateModuloCommandResponse(ModuloOutputDto modulo)
        {
            Modulo = modulo;
        }
    }
}
