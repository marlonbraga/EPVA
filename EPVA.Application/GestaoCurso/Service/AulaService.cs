using AutoMapper;
using EPVA.Application.GestaoCurso.Dto;
using EPVA.Domain.PlanoAula;
using EPVA.Domain.PlanoAula.Repository;

namespace EPVA.Application.GestaoCurso.Service
{
    public class AulaService : IAulaService
    {
        private readonly IAulaRepository aulaRepository;
        private readonly IMapper mapper;

        public AulaService(IAulaRepository aulaRepository, IMapper mapper)
        {
            this.aulaRepository = aulaRepository;
            this.mapper = mapper;
        }

        public async Task<AulaOutputDto> Criar(AulaInputDto dto)
        {
            var aula = this.mapper.Map<Aula>(dto);
            await this.aulaRepository.Save(aula);
            return this.mapper.Map<AulaOutputDto>(aula);
        }

        public async Task<List<AulaOutputDto>> ObterTodos()
        {
            var aula = await this.aulaRepository.GetAll();
            return this.mapper.Map<List<AulaOutputDto>>(aula);
        }

        public async Task<AulaOutputDto> Deletar(Guid id)
        {
            var Aula = await this.aulaRepository.Get(id);
            await this.aulaRepository.Delete(Aula);
            return this.mapper.Map<AulaOutputDto>(Aula);
        }

        public async Task<AulaOutputDto> Editar(Guid id, AulaInputDto dto)
        {
            var aula = this.mapper.Map<Aula>(dto);
            aula.Id = id;
            await this.aulaRepository.Update(aula);
            return this.mapper.Map<AulaOutputDto>(aula);
        }

        public async Task<AulaOutputDto> Obter(Guid id)
        {
            var Aula = await this.aulaRepository.Get(id);
            return this.mapper.Map<AulaOutputDto>(Aula);
        }
    }
}
