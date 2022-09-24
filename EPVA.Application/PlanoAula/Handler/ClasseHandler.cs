using EPVA.Application.PlanoAula.Handler.Command;
using EPVA.Application.PlanoAula.Handler.Query;
using EPVA.Application.PlanoAula.Service;
using MediatR;

namespace EPVA.Application.PlanoAula.Handler
{
    public class ClasseHandler : IRequestHandler<CreateClasseCommand, CreateClasseCommandResponse>,
                                IRequestHandler<GetAllClasseQuery, GetAllClasseQueryResponse>,
                                IRequestHandler<GetClasseQuery, GetClasseQueryResponse>,
                                IRequestHandler<DeleteClasseCommand, DeleteClasseCommandResponse>,
                                IRequestHandler<EditClasseCommand, EditClasseCommandResponse>
    {
        private readonly IClasseService _classeService;

        public ClasseHandler(IClasseService classeService)
        {
            _classeService = classeService;
        }

        public async Task<CreateClasseCommandResponse> Handle(CreateClasseCommand request, CancellationToken cancellationToken)
        {
            var result = await _classeService.Criar(request.Classe);
            return new CreateClasseCommandResponse(result);
        }

        public async Task<GetAllClasseQueryResponse> Handle(GetAllClasseQuery request, CancellationToken cancellationToken)
        {
            var result = await _classeService.ObterTodos();
            return new GetAllClasseQueryResponse(result);
        }

        public async Task<GetClasseQueryResponse> Handle(GetClasseQuery request, CancellationToken cancellationToken)
        {
            var result = await _classeService.Obter(request.IdClasse);
            return new GetClasseQueryResponse(result);
        }

        public async Task<DeleteClasseCommandResponse> Handle(DeleteClasseCommand request, CancellationToken cancellationToken)
        {
            await _classeService.Deletar(request.IdClasse);
            return new DeleteClasseCommandResponse();
        }

        public async Task<EditClasseCommandResponse> Handle(EditClasseCommand request, CancellationToken cancellationToken)
        {
            var result = await _classeService.Editar(request.IdClasse, request.Classe);
            return new EditClasseCommandResponse(result);
        }
    }
}
