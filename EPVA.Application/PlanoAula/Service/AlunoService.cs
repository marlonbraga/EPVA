using AutoMapper;
using EPVA.Application.PlanoAula.Dto;
using EPVA.Domain.GestaoCurso;
using EPVA.Domain.GestaoCurso.Repository;

namespace EPVA.Application.PlanoAula.Service
{
    public class AlunoService : IAlunoService
    {
        private readonly IAlunoRepository alunoRepository;
        private readonly IMapper mapper;

        public AlunoService(IAlunoRepository alunoRepository, IMapper mapper)
        {
            this.alunoRepository = alunoRepository;
            this.mapper = mapper;
        }

        public async Task<AlunoOutputDto> Criar(AlunoInputDto dto)
        {
            var aluno = mapper.Map<Aluno>(dto);
            await alunoRepository.Save(aluno);
            return mapper.Map<AlunoOutputDto>(aluno);
        }

        public async Task<List<AlunoOutputDto>> ObterTodos()
        {
            var aluno = await alunoRepository.GetAll();
            return mapper.Map<List<AlunoOutputDto>>(aluno);
        }

        public async Task<AlunoOutputDto> Deletar(Guid id)
        {
            var Aluno = await alunoRepository.Get(id);
            await alunoRepository.Delete(Aluno);
            return mapper.Map<AlunoOutputDto>(Aluno);
        }

        public async Task<AlunoOutputDto> Editar(Guid id, AlunoInputDto dto)
        {
            var aluno = mapper.Map<Aluno>(dto);
            aluno.Id = id;
            await alunoRepository.Update(aluno);
            return mapper.Map<AlunoOutputDto>(aluno);
        }

        public async Task<AlunoOutputDto> Obter(Guid id)
        {
            var Aluno = await alunoRepository.Get(id);
            return mapper.Map<AlunoOutputDto>(Aluno);
        }
    }
}
