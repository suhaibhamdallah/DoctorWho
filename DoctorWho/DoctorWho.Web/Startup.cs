using DoctorWho.Db;
using DoctorWho.Db.Models;
using DoctorWho.Db.Repositories;
using DoctorWho.Web.Models;
using DoctorWho.Web.Services;
using DoctorWho.Web.Validators;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace DoctorWho.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers(setupAction =>
            {
                setupAction.ReturnHttpNotAcceptable = true;
            }).AddNewtonsoftJson(); ;

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddTransient<IRepository<Doctor, Doctor, int>, DoctorRepository>();

            services.AddTransient<IRepository<Episode, EpisodesView, int>, EpisodeRepository>();

            services.AddTransient<IRepository<Author, Author, int>, AuthorRepository>();

            services.AddTransient<IRepository<Enemy, Enemy, int>, EnemyRepository>();

            services.AddTransient<IRepository<EpisodeEnemy, EpisodeEnemy, int>, EpisodeEnemyRepository>();

            services.AddTransient<IRepository<Companion, Companion, int>, CompanionRepository>();

            services.AddTransient<IRepository<EpisodeCompanion, EpisodeCompanion, int>, EpisodeCompanionRepository>();

            services.AddTransient<IDoctorService, DoctorService>();

            services.AddTransient<IEpisodeService, EpisodeService>();

            services.AddTransient<IAuthorService, AuthorService>();

            services.AddTransient<IEnemyService, EnemyService>();

            services.AddTransient<IEpisodeEnemyService, EpisodeEnemyService>();

            services.AddTransient<ICompanionService, CompanionService>();

            services.AddTransient<IEpisodeCompanionService, EpisodeCompanionService>();

            services.AddDbContext<DoctorWhoCoreDbContext>(options =>
            {
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                options.UseSqlServer(Configuration.GetConnectionString("DB"));
            }, ServiceLifetime.Transient);

            services.AddFluentValidation();

            services.AddTransient<IValidator<DoctorForManipulationDto>, DoctorForManipulationDtoValidator>();

            services.AddTransient<IValidator<EpisodeForCreationDto>, EpisodeForCreationDtoValidator>();

            services.AddTransient<IValidator<AuthorDto>, AuthorDtoValidator>();

            // services.AddTransient<IValidator<EpisodeEnemyForCreationDto>, EpisodeEnemyForCreationDtoValidator>();

            // services.AddTransient<IValidator<EpisodeCompanionForCreationDto>, EpisodeCompanionForCreationDtoValidator>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler(appBulider =>
                {
                    appBulider.Run(async context =>
                    {
                        context.Response.StatusCode = 500;
                        await context.Response.WriteAsync("An unexpected fault happened. Try again later.");
                    });
                });
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
