using EPVA.Domain.GestaoCurso.Repository;
using EPVA.Domain.PlanoAula.Repository;
using EPVA.Repository.Context;
using EPVA.Repository.Database;
using EPVA.Repository.Infrastructure;
using EPVA.Repository.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EPVA.Repository
{
    public static class ConfigurationModule
    {
        public static IServiceCollection RegisterRepository(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<EPVAContext>(c =>
            {
                c.UseSqlServer(connectionString);
            });

            services.AddScoped(typeof(Repository<>));
            services.AddScoped<IAulaRepository, AulaRepository>();
            services.AddScoped<IAlunoRepository, AlunoRepository>();
            services.AddScoped<IProfessorRepository, ProfessorRepository>();
            services.AddScoped<IModuloRepository, ModuloRepository>();
            services.AddScoped<IClasseRepository, ClasseRepository>();
            services.AddScoped<IMaterialRepository, MaterialRepository>();
            services.AddScoped<AzureBlobStorage>();
            //services.AddHttpClient();

            return services;
        }
    }
}
