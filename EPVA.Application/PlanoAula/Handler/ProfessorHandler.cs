using EPVA.Application.PlanoAula.Handler.Command;
using EPVA.Application.PlanoAula.Handler.Query;
using EPVA.Application.PlanoAula.Service;
using MediatR;

namespace EPVA.Application.PlanoAula.Handler
{
    public class ProfessorHandler : IRequestHandler<CreateProfessorCommand, CreateProfessorCommandResponse>,
                                IRequestHandler<GetAllProfessorQuery, GetAllProfessorQueryResponse>,
                                IRequestHandler<GetProfessorQuery, GetProfessorQueryResponse>,
                                IRequestHandler<DeleteProfessorCommand, DeleteProfessorCommandResponse>,
                                IRequestHandler<EditProfessorCommand, EditProfessorCommandResponse>
    {
        private readonly IProfessorService _professorService;

        public ProfessorHandler(IProfessorService professorService)
        {
            _professorService = professorService;
        }

        public async Task<CreateProfessorCommandResponse> Handle(CreateProfessorCommand request, CancellationToken cancellationToken)
        {
            var result = await _professorService.Criar(request.Professor);
            return new CreateProfessorCommandResponse(result);
        }

        public async Task<GetAllProfessorQueryResponse> Handle(GetAllProfessorQuery request, CancellationToken cancellationToken)
        {
            var result = await _professorService.ObterTodos();
            return new GetAllProfessorQueryResponse(result);
        }

        public async Task<GetProfessorQueryResponse> Handle(GetProfessorQuery request, CancellationToken cancellationToken)
        {
            var result = await _professorService.Obter(request.IdProfessor);
            return new GetProfessorQueryResponse(result);
        }

        public async Task<DeleteProfessorCommandResponse> Handle(DeleteProfessorCommand request, CancellationToken cancellationToken)
        {
            await _professorService.Deletar(request.IdProfessor);
            return new DeleteProfessorCommandResponse();
        }

        public async Task<EditProfessorCommandResponse> Handle(EditProfessorCommand request, CancellationToken cancellationToken)
        {
            var result = await _professorService.Editar(request.IdProfessor, request.Professor);
            return new EditProfessorCommandResponse(result);
        }
    }
}
