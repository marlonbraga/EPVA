using AutoMapper;
using EPVA.Application.PlanoAula.Dto;
using EPVA.Domain.GestaoCurso;
using EPVA.Domain.GestaoCurso.Repository;

namespace EPVA.Application.PlanoAula.Service
{
    public class ProfessorService : IProfessorService
    {
        private readonly IProfessorRepository professorRepository;
        private readonly IMapper mapper;

        public ProfessorService(IProfessorRepository professorRepository, IMapper mapper)
        {
            this.professorRepository = professorRepository;
            this.mapper = mapper;
        }

        public async Task<ProfessorOutputDto> Criar(ProfessorInputDto dto)
        {
            var professor = mapper.Map<Professor>(dto);
            await professorRepository.Save(professor);
            return mapper.Map<ProfessorOutputDto>(professor);
        }

        public async Task<List<ProfessorOutputDto>> ObterTodos()
        {
            var professor = await professorRepository.GetAll();
            return mapper.Map<List<ProfessorOutputDto>>(professor);
        }

        public async Task<ProfessorOutputDto> Deletar(Guid id)
        {
            var Professor = await professorRepository.Get(id);
            await professorRepository.Delete(Professor);
            return mapper.Map<ProfessorOutputDto>(Professor);
        }

        public async Task<ProfessorOutputDto> Editar(Guid id, ProfessorInputDto dto)
        {
            var professor = mapper.Map<Professor>(dto);
            professor.Id = id;
            await professorRepository.Update(professor);
            return mapper.Map<ProfessorOutputDto>(professor);
        }

        public async Task<ProfessorOutputDto> Obter(Guid id)
        {
            var Professor = await professorRepository.Get(id);
            return mapper.Map<ProfessorOutputDto>(Professor);
        }
    }
}
