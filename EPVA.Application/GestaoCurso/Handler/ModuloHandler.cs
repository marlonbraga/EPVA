using EPVA.Application.GestaoCurso.Handler.Command;
using EPVA.Application.GestaoCurso.Handler.Query;
using EPVA.Application.GestaoCurso.Service;
using MediatR;

namespace EPVA.Application.GestaoCurso.Handler
{
    public class ModuloHandler : IRequestHandler<CreateModuloCommand, CreateModuloCommandResponse>,
                                IRequestHandler<GetAllModuloQuery, GetAllModuloQueryResponse>,
                                IRequestHandler<GetModuloQuery, GetModuloQueryResponse>,
                                IRequestHandler<DeleteModuloCommand, DeleteModuloCommandResponse>,
                                IRequestHandler<EditModuloCommand, EditModuloCommandResponse>
    {
        private readonly IModuloService _moduloService;

        public ModuloHandler(IModuloService moduloService)
        {
            _moduloService = moduloService;
        }

        public async Task<CreateModuloCommandResponse> Handle(CreateModuloCommand request, CancellationToken cancellationToken)
        {
            var result = await _moduloService.Criar(request.Modulo);
            return new CreateModuloCommandResponse(result);
        }

        public async Task<GetAllModuloQueryResponse> Handle(GetAllModuloQuery request, CancellationToken cancellationToken)
        {
            var result = await _moduloService.ObterTodos();
            return new GetAllModuloQueryResponse(result);
        }

        public async Task<GetModuloQueryResponse> Handle(GetModuloQuery request, CancellationToken cancellationToken)
        {
            var result = await _moduloService.Obter(request.IdModulo);
            return new GetModuloQueryResponse(result);
        }

        public async Task<DeleteModuloCommandResponse> Handle(DeleteModuloCommand request, CancellationToken cancellationToken)
        {
            await _moduloService.Deletar(request.IdModulo);
            return new DeleteModuloCommandResponse();
        }

        public async Task<EditModuloCommandResponse> Handle(EditModuloCommand request, CancellationToken cancellationToken)
        {
            var result = await _moduloService.Editar(request.IdModulo, request.Modulo);
            return new EditModuloCommandResponse(result);
        }
    }
}
