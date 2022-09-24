using EPVA.Application.GestaoCurso.Handler.Command;
using EPVA.Application.GestaoCurso.Handler.Query;
using EPVA.Application.GestaoCurso.Service;
using MediatR;

namespace EPVA.Application.GestaoCurso.Handler
{
    public class MaterialHandler : IRequestHandler<CreateMaterialCommand, CreateMaterialCommandResponse>,
                                IRequestHandler<GetAllMaterialQuery, GetAllMaterialQueryResponse>,
                                IRequestHandler<GetMaterialQuery, GetMaterialQueryResponse>,
                                IRequestHandler<DeleteMaterialCommand, DeleteMaterialCommandResponse>,
                                IRequestHandler<EditMaterialCommand, EditMaterialCommandResponse>
    {
        private readonly IMaterialService _materialService;

        public MaterialHandler(IMaterialService materialService)
        {
            _materialService = materialService;
        }

        public async Task<CreateMaterialCommandResponse> Handle(CreateMaterialCommand request, CancellationToken cancellationToken)
        {
            var result = await _materialService.Criar(request.Material);
            return new CreateMaterialCommandResponse(result);
        }

        public async Task<GetAllMaterialQueryResponse> Handle(GetAllMaterialQuery request, CancellationToken cancellationToken)
        {
            var result = await _materialService.ObterTodos();
            return new GetAllMaterialQueryResponse(result);
        }

        public async Task<GetMaterialQueryResponse> Handle(GetMaterialQuery request, CancellationToken cancellationToken)
        {
            var result = await _materialService.Obter(request.IdMaterial);
            return new GetMaterialQueryResponse(result);
        }

        public async Task<DeleteMaterialCommandResponse> Handle(DeleteMaterialCommand request, CancellationToken cancellationToken)
        {
            await _materialService.Deletar(request.IdMaterial);
            return new DeleteMaterialCommandResponse();
        }

        public async Task<EditMaterialCommandResponse> Handle(EditMaterialCommand request, CancellationToken cancellationToken)
        {
            var result = await _materialService.Editar(request.IdMaterial, request.Material);
            return new EditMaterialCommandResponse(result);
        }
    }
}
