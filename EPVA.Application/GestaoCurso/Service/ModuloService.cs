using AutoMapper;
using EPVA.Application.GestaoCurso.Dto;
using EPVA.Domain.PlanoAula;
using EPVA.Domain.PlanoAula.Repository;

namespace EPVA.Application.GestaoCurso.Service
{
    public class ModuloService : IModuloService
    {
        private readonly IModuloRepository moduloRepository;
        private readonly IMapper mapper;

        public ModuloService(IModuloRepository moduloRepository, IMapper mapper)
        {
            this.moduloRepository = moduloRepository;
            this.mapper = mapper;
        }

        public async Task<ModuloOutputDto> Criar(ModuloInputDto dto)
        {
            var modulo = this.mapper.Map<Modulo>(dto);
            await this.moduloRepository.Save(modulo);
            return this.mapper.Map<ModuloOutputDto>(modulo);
        }

        public async Task<List<ModuloOutputDto>> ObterTodos()
        {
            var modulo = await this.moduloRepository.GetAll();
            return this.mapper.Map<List<ModuloOutputDto>>(modulo);
        }

        public async Task<ModuloOutputDto> Deletar(Guid id)
        {
            var Modulo = await this.moduloRepository.Get(id);
            await this.moduloRepository.Delete(Modulo);
            return this.mapper.Map<ModuloOutputDto>(Modulo);
        }

        public async Task<ModuloOutputDto> Editar(Guid id, ModuloInputDto dto)
        {
            var modulo = this.mapper.Map<Modulo>(dto);
            modulo.Id = id;
            await this.moduloRepository.Update(modulo);
            return this.mapper.Map<ModuloOutputDto>(modulo);
        }

        public async Task<ModuloOutputDto> Obter(Guid id)
        {
            var Modulo = await this.moduloRepository.Get(id);
            return this.mapper.Map<ModuloOutputDto>(Modulo);
        }
    }
}
