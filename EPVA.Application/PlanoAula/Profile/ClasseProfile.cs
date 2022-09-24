using EPVA.Application.PlanoAula.Dto;
using EPVA.Domain.GestaoCurso;

namespace EPVA.Application.PlanoAula.Profile
{
    public class ClasseProfile : AutoMapper.Profile
    {
        public ClasseProfile()
        {
            CreateMap<Classe, ClasseOutputDto>();

            CreateMap<ClasseInputDto, Classe>();

            CreateMap<Professor, ProfessorOutputDto>();

            CreateMap<ProfessorInputDto, Professor>();

            CreateMap<Aluno, AlunoOutputDto>();

            CreateMap<AlunoInputDto, Aluno>();
        }
    }
}
