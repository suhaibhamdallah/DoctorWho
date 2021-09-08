using DoctorWho.Db.Models;
using DoctorWho.Db.Repositories;
using DoctorWho.Web.Models;
using DoctorWho.Web.Services;
using DoctorWho.Web.Validators;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;

namespace DoctorWho.Web.Extensions
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Inject required repositories
        /// </summary>
        /// <param name="services"></param>
        public static void AddRequiredRepositories(this IServiceCollection services)
        {
            services.AddTransient<IRepository<Doctor, Doctor, int>, DoctorRepository>();

            services.AddTransient<IRepository<Episode, EpisodesView, int>, EpisodeRepository>();

            services.AddTransient<IRepository<Author, Author, int>, AuthorRepository>();

            services.AddTransient<IRepository<Enemy, Enemy, int>, EnemyRepository>();

            services.AddTransient<IRepository<EpisodeEnemy, EpisodeEnemy, int>, EpisodeEnemyRepository>();

            services.AddTransient<IRepository<Companion, Companion, int>, CompanionRepository>();

            services.AddTransient<IRepository<EpisodeCompanion, EpisodeCompanion, int>, EpisodeCompanionRepository>();

            services.AddTransient<IInformationRequestRepository<InformationRequest, InformationRequest, string>, InformationRequestRepository>();
        }

        /// <summary>
        /// Inject required repositories
        /// </summary>
        /// <param name="services"></param>
        public static void AddRequiredServices(this IServiceCollection services)
        {
            services.AddTransient<IDoctorService, DoctorService>();

            services.AddTransient<IEpisodeService, EpisodeService>();

            services.AddTransient<IAuthorService, AuthorService>();

            services.AddTransient<IEnemyService, EnemyService>();

            services.AddTransient<IEpisodeEnemyService, EpisodeEnemyService>();

            services.AddTransient<ICompanionService, CompanionService>();

            services.AddTransient<IEpisodeCompanionService, EpisodeCompanionService>();

            services.AddTransient<IInformationRequestService, InformationRequestService>();
        }

        public static void AddRequiredValidators(this IServiceCollection services)
        {
            services.AddFluentValidation();

            services.AddTransient<IValidator<DoctorForManipulationDto>, DoctorForManipulationDtoValidator>();

            services.AddTransient<IValidator<EpisodeForCreationDto>, EpisodeForCreationDtoValidator>();

            services.AddTransient<IValidator<AuthorDto>, AuthorDtoValidator>();

            services.AddTransient<IValidator<EpisodeEnemyForCreationDto>, EpisodeEnemyForCreationDtoValidator>();

            services.AddTransient<IValidator<EpisodeCompanionForCreationDto>, EpisodeCompanionForCreationDtoValidator>();

            services.AddTransient<IValidator<InformationRequestForCreationDto>, InformationRequestForCreationDtoValidator>();
        }
    }
}
