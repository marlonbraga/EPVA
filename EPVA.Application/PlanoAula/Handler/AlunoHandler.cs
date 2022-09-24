using EPVA.Application.PlanoAula.Handler.Command;
using EPVA.Application.PlanoAula.Handler.Query;
using EPVA.Application.PlanoAula.Service;
using MediatR;

namespace EPVA.Application.PlanoAula.Handler
{
    public class AlunoHandler : IRequestHandler<CreateAlunoCommand, CreateAlunoCommandResponse>,
                                IRequestHandler<GetAllAlunoQuery, GetAllAlunoQueryResponse>,
                                IRequestHandler<GetAlunoQuery, GetAlunoQueryResponse>,
                                IRequestHandler<DeleteAlunoCommand, DeleteAlunoCommandResponse>,
                                IRequestHandler<EditAlunoCommand, EditAlunoCommandResponse>
    {
        private readonly IAlunoService _alunoService;

        public AlunoHandler(IAlunoService alunoService)
        {
            _alunoService = alunoService;
        }

        public async Task<CreateAlunoCommandResponse> Handle(CreateAlunoCommand request, CancellationToken cancellationToken)
        {
            var result = await _alunoService.Criar(request.Aluno);
            return new CreateAlunoCommandResponse(result);
        }

        public async Task<GetAllAlunoQueryResponse> Handle(GetAllAlunoQuery request, CancellationToken cancellationToken)
        {
            var result = await _alunoService.ObterTodos();
            return new GetAllAlunoQueryResponse(result);
        }

        public async Task<GetAlunoQueryResponse> Handle(GetAlunoQuery request, CancellationToken cancellationToken)
        {
            var result = await _alunoService.Obter(request.IdAluno);
            return new GetAlunoQueryResponse(result);
        }

        public async Task<DeleteAlunoCommandResponse> Handle(DeleteAlunoCommand request, CancellationToken cancellationToken)
        {
            await _alunoService.Deletar(request.IdAluno);
            return new DeleteAlunoCommandResponse();
        }

        public async Task<EditAlunoCommandResponse> Handle(EditAlunoCommand request, CancellationToken cancellationToken)
        {
            var result = await _alunoService.Editar(request.IdAluno, request.Aluno);
            return new EditAlunoCommandResponse(result);
        }
    }
}
