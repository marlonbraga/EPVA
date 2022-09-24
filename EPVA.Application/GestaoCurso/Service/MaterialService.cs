using AutoMapper;
using EPVA.Application.GestaoCurso.Dto;
using EPVA.Domain.PlanoAula;
using EPVA.Domain.PlanoAula.Repository;

namespace EPVA.Application.GestaoCurso.Service
{
    public class MaterialService : IMaterialService
    {
        private readonly IMaterialRepository materialRepository;
        private readonly IMapper mapper;

        public MaterialService(IMaterialRepository materialRepository, IMapper mapper)
        {
            this.materialRepository = materialRepository;
            this.mapper = mapper;
        }

        public async Task<MaterialOutputDto> Criar(MaterialInputDto dto)
        {
            var material = this.mapper.Map<Material>(dto);
            await this.materialRepository.Save(material);
            return this.mapper.Map<MaterialOutputDto>(material);
        }

        public async Task<List<MaterialOutputDto>> ObterTodos()
        {
            var material = await this.materialRepository.GetAll();
            return this.mapper.Map<List<MaterialOutputDto>>(material);
        }

        public async Task<MaterialOutputDto> Deletar(Guid id)
        {
            var Material = await this.materialRepository.Get(id);
            await this.materialRepository.Delete(Material);
            return this.mapper.Map<MaterialOutputDto>(Material);
        }

        public async Task<MaterialOutputDto> Editar(Guid id, MaterialInputDto dto)
        {
            var material = this.mapper.Map<Material>(dto);
            material.Id = id;
            await this.materialRepository.Update(material);
            return this.mapper.Map<MaterialOutputDto>(material);
        }

        public async Task<MaterialOutputDto> Obter(Guid id)
        {
            var Material = await this.materialRepository.Get(id);
            return this.mapper.Map<MaterialOutputDto>(Material);
        }
    }
}
