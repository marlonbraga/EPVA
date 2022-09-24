using EPVA.Application.GestaoCurso.Handler.Command;
using EPVA.Application.GestaoCurso.Handler.Query;
using EPVA.Application.GestaoCurso.Service;
using EPVA.Application.PlanoAula.Handler.Command;
using EPVA.Application.PlanoAula.Handler.Query;
using EPVA.Application.PlanoAula.Service;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace EPVA.Application
{
    public static class ConfigurationModule
    {
        public static IServiceCollection RegisterApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Application.ConfigurationModule).Assembly);

            //AddMediatR(services);
            services.AddMediatR(typeof(Application.ConfigurationModule).Assembly);

            services.AddScoped<IAulaService, AulaService>();
            services.AddScoped<IMaterialService, MaterialService>();
            services.AddScoped<IModuloService, ModuloService>();
            services.AddScoped<IClasseService, ClasseService>();
            services.AddScoped<IAlunoService, AlunoService>();
            services.AddScoped<IProfessorService, ProfessorService>();

            return services;
        }

        private static void AddMediatR(this IServiceCollection services)
        {
            services.AddMediatR(typeof(GetAllAulaQuery));
            services.AddMediatR(typeof(GetAllMaterialQuery));
            services.AddMediatR(typeof(GetAllModuloQuery));
            services.AddMediatR(typeof(GetAulaQuery));
            services.AddMediatR(typeof(GetMaterialQuery));
            services.AddMediatR(typeof(GetModuloQuery));

            services.AddMediatR(typeof(CreateAulaCommand));
            services.AddMediatR(typeof(CreateMaterialCommand));
            services.AddMediatR(typeof(CreateModuloCommand));
            services.AddMediatR(typeof(DeleteAulaCommand));
            services.AddMediatR(typeof(DeleteMaterialCommand));
            services.AddMediatR(typeof(DeleteModuloCommand));
            services.AddMediatR(typeof(EditAulaCommand));
            services.AddMediatR(typeof(EditMaterialCommand));
            services.AddMediatR(typeof(EditModuloCommand));

            services.AddMediatR(typeof(GetAllAlunoQuery));
            services.AddMediatR(typeof(GetAllClasseQuery));
            services.AddMediatR(typeof(GetAllProfessorQuery));
            services.AddMediatR(typeof(GetAlunoQuery));
            services.AddMediatR(typeof(GetClasseQuery));
            services.AddMediatR(typeof(GetProfessorQuery));

            services.AddMediatR(typeof(CreateAlunoCommand));
            services.AddMediatR(typeof(CreateClasseCommand));
            services.AddMediatR(typeof(CreateProfessorCommand));
            services.AddMediatR(typeof(DeleteAlunoCommand));
            services.AddMediatR(typeof(DeleteClasseCommand));
            services.AddMediatR(typeof(DeleteProfessorCommand));
            services.AddMediatR(typeof(EditAlunoCommand));
            services.AddMediatR(typeof(EditClasseCommand));
            services.AddMediatR(typeof(EditProfessorCommand));
        }
    }
}
