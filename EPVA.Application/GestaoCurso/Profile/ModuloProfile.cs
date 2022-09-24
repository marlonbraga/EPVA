using EPVA.Application.GestaoCurso.Dto;
using EPVA.Domain.PlanoAula;

namespace EPVA.Application.GestaoCurso.Profile
{
    public class ModuloProfile : AutoMapper.Profile
    {
        public ModuloProfile()
        {
            CreateMap<Material, MaterialOutputDto>();

            CreateMap<MaterialInputDto, Material>();

            CreateMap<Modulo, ModuloOutputDto>();

            CreateMap<ModuloInputDto, Modulo>();

            CreateMap<Aula, AulaOutputDto>();

            CreateMap<AulaInputDto, Aula>();
        }
    }
}
