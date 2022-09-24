using EPVA.Application.GestaoCurso.Handler.Command;
using EPVA.Application.GestaoCurso.Handler.Query;
using EPVA.Application.GestaoCurso.Service;
using MediatR;

namespace EPVA.Application.GestaoCurso.Handler
{
    public class AlunoHandler : IRequestHandler<CreateAulaCommand, CreateAulaCommandResponse>,
                                IRequestHandler<GetAllAulaQuery, GetAllAulaQueryResponse>,
                                IRequestHandler<GetAulaQuery, GetAulaQueryResponse>,
                                IRequestHandler<DeleteAulaCommand, DeleteAulaCommandResponse>,
                                IRequestHandler<EditAulaCommand, EditAulaCommandResponse>
    {
        private readonly IAulaService _aulaService;

        public AlunoHandler(IAulaService aulaService)
        {
            _aulaService = aulaService;
        }

        public async Task<CreateAulaCommandResponse> Handle(CreateAulaCommand request, CancellationToken cancellationToken)
        {
            var result = await _aulaService.Criar(request.Aula);
            return new CreateAulaCommandResponse(result);
        }

        public async Task<GetAllAulaQueryResponse> Handle(GetAllAulaQuery request, CancellationToken cancellationToken)
        {
            var result = await _aulaService.ObterTodos();
            return new GetAllAulaQueryResponse(result);
        }

        public async Task<GetAulaQueryResponse> Handle(GetAulaQuery request, CancellationToken cancellationToken)
        {
            var result = await _aulaService.Obter(request.IdAula);
            return new GetAulaQueryResponse(result);
        }

        public async Task<DeleteAulaCommandResponse> Handle(DeleteAulaCommand request, CancellationToken cancellationToken)
        {
            await _aulaService.Deletar(request.IdAula);
            return new DeleteAulaCommandResponse();
        }

        public async Task<EditAulaCommandResponse> Handle(EditAulaCommand request, CancellationToken cancellationToken)
        {
            var result = await _aulaService.Editar(request.IdAula, request.Aula);
            return new EditAulaCommandResponse(result);
        }
    }
}
