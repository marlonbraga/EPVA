using AutoMapper;
using EPVA.Application.PlanoAula.Dto;
using EPVA.Domain.GestaoCurso;
using EPVA.Domain.GestaoCurso.Repository;

namespace EPVA.Application.PlanoAula.Service
{
    public class ClasseService : IClasseService
    {
        private readonly IClasseRepository classeRepository;
        private readonly IMapper mapper;

        public ClasseService(IClasseRepository classeRepository, IMapper mapper)
        {
            this.classeRepository = classeRepository;
            this.mapper = mapper;
        }

        public async Task<ClasseOutputDto> Criar(ClasseInputDto dto)
        {
            var classe = mapper.Map<Classe>(dto);
            await classeRepository.Save(classe);
            return mapper.Map<ClasseOutputDto>(classe);
        }

        public async Task<List<ClasseOutputDto>> ObterTodos()
        {
            var classe = await classeRepository.GetAll();
            return mapper.Map<List<ClasseOutputDto>>(classe);
        }

        public async Task<ClasseOutputDto> Deletar(Guid id)
        {
            var Classe = await classeRepository.Get(id);
            await classeRepository.Delete(Classe);
            return mapper.Map<ClasseOutputDto>(Classe);
        }

        public async Task<ClasseOutputDto> Editar(Guid id, ClasseInputDto dto)
        {
            var classe = mapper.Map<Classe>(dto);
            classe.Id = id;
            await classeRepository.Update(classe);
            return mapper.Map<ClasseOutputDto>(classe);
        }

        public async Task<ClasseOutputDto> Obter(Guid id)
        {
            var Classe = await classeRepository.Get(id);
            return mapper.Map<ClasseOutputDto>(Classe);
        }
    }
}
