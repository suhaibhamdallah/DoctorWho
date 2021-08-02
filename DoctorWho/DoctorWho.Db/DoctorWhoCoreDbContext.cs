using DoctorWho.Db.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DoctorWho.Db
{
    public class DoctorWhoCoreDbContext : DbContext
    {
        public DbSet<Enemy> Enemies { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Companion> Companions { get; set; }
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<EpisodeCompanion> EpisodeCompanions { get; set; }
        public DbSet<EpisodeEnemy> EpisodeEnemies { get; set; }
        public DbSet<ViewEpisodes> ViewEpisodes { get; set; }

        public DoctorWhoCoreDbContext()
        {

        }

        public DoctorWhoCoreDbContext(DbContextOptions<DoctorWhoCoreDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // TODO: CHANGE CONNECTION STRING
            optionsBuilder.UseSqlServer(
                "Server = DESKTOP-EDE547A; Database = DoctorWhoCore; Trusted_Connection = True"
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Seed Tables

            modelBuilder.Entity<Author>().HasData(
                new Author { AuthorId = 1, AuthorName = "Suhaib Hamdallah" },
                new Author { AuthorId = 2, AuthorName = "Anas Zakarneh" },
                new Author { AuthorId = 3, AuthorName = "Mohammad Abu-Qasedo" },
                new Author { AuthorId = 4, AuthorName = "Stephen Hillenburg" },
                new Author { AuthorId = 5, AuthorName = "Craig McCracken" },
                new Author { AuthorId = 6, AuthorName = "Genndy Tartakovsky" },
                new Author { AuthorId = 7, AuthorName = "Alex Hirsch" },
                new Author { AuthorId = 8, AuthorName = "Butch Hartman" }
            );

            modelBuilder.Entity<Companion>().HasData(
                new Companion { CompanionId = 1, CompanionName = "Zaid Nour" },
                new Companion { CompanionId = 2, CompanionName = "Jweid Hamdallah" },
                new Companion { CompanionId = 3, CompanionName = "Amjad Salhab" },
                new Companion { CompanionId = 4, CompanionName = "Osaid Nour" },
                new Companion { CompanionId = 5, CompanionName = "Yazan Fouqha" },
                new Companion { CompanionId = 6, CompanionName = "Osaid Hamdallah" },
                new Companion { CompanionId = 7, CompanionName = "Hasan Khalaf" },
                new Companion { CompanionId = 8, CompanionName = "Rayan Hamdallah" }
            );

            modelBuilder.Entity<Doctor>().HasData(
                new Doctor { DoctorId = 1, DoctorNumber = 1, DoctorName = "Dr. William A. Abdu, M.D, M.S.", BithDate = new DateTime(1962, 7, 14) },
                new Doctor { DoctorId = 2, DoctorNumber = 2, DoctorName = "Dr. Myles. B. Abbott, M.D.", BithDate = new DateTime(1962, 7, 14) },
                new Doctor { DoctorId = 3, DoctorNumber = 3, DoctorName = "Dr. Khalid Abbed, M.D.", BithDate = new DateTime(1962, 7, 14) },
                new Doctor { DoctorId = 4, DoctorNumber = 4, DoctorName = "Dr. Fouad. M. Abbas, M.D.", BithDate = new DateTime(1962, 7, 14) },
                new Doctor { DoctorId = 5, DoctorNumber = 5, DoctorName = "Dr. Naresh Trehan", BithDate = new DateTime(1962, 7, 14) },
                new Doctor { DoctorId = 6, DoctorNumber = 6, DoctorName = "Dr. Ahmad Assi", BithDate = new DateTime(1962, 7, 14) },
                new Doctor { DoctorId = 7, DoctorNumber = 7, DoctorName = "Dr. Laith Sharaqa", BithDate = new DateTime(1962, 7, 14) },
                new Doctor { DoctorId = 8, DoctorNumber = 8, DoctorName = "Dr. Hamza Nour", BithDate = new DateTime(1962, 7, 14) }
            );

            modelBuilder.Entity<Enemy>().HasData(
                new Enemy { EnemyId = 1, EnemyName = "Eric Cartman", Description = "bla bla" },
                new Enemy { EnemyId = 2, EnemyName = "Vicky", Description = "bla bla" },
                new Enemy { EnemyId = 3, EnemyName = "Stewie Griffin", Description = "bla bla" },
                new Enemy { EnemyId = 4, EnemyName = "Maleficent", Description = "bla bla" },
                new Enemy { EnemyId = 5, EnemyName = "Mr. Pickles ", Description = "bla bla" },
                new Enemy { EnemyId = 6, EnemyName = "Ahmad Nassar", Description = "bla bla" },
                new Enemy { EnemyId = 7, EnemyName = "Mohammad Domidi", Description = "bla bla" },
                new Enemy { EnemyId = 8, EnemyName = "Ammar Omar", Description = "bla bla" }
            );

            modelBuilder.Entity<Episode>().HasData(
                new Episode { EpisodeId = 1, SeriesNumber = 1, EpisodeNumber = 1, EpisodeType = "TYPE 1", EpisodeTitle = "TITLE 1", EpisodeDate = new DateTime(2018, 7, 18), AuthorId = 1, DoctorId = 1 },
                new Episode { EpisodeId = 2, SeriesNumber = 1, EpisodeNumber = 1, EpisodeType = "TYPE 2", EpisodeTitle = "TITLE 2", EpisodeDate = new DateTime(2018, 7, 18), AuthorId = 2, DoctorId = 2 },
                new Episode { EpisodeId = 3, SeriesNumber = 1, EpisodeNumber = 1, EpisodeType = "TYPE 3", EpisodeTitle = "TITLE 3", EpisodeDate = new DateTime(2018, 7, 18), AuthorId = 3, DoctorId = 3 },
                new Episode { EpisodeId = 4, SeriesNumber = 1, EpisodeNumber = 1, EpisodeType = "TYPE 3", EpisodeTitle = "TITLE 4", EpisodeDate = new DateTime(2018, 7, 18), AuthorId = 3, DoctorId = 4 },
                new Episode { EpisodeId = 5, SeriesNumber = 2, EpisodeNumber = 1, EpisodeType = "TYPE 2", EpisodeTitle = "TITLE 5", EpisodeDate = new DateTime(2018, 7, 18), AuthorId = 4, DoctorId = 5 },
                new Episode { EpisodeId = 6, SeriesNumber = 2, EpisodeNumber = 1, EpisodeType = "TYPE 1", EpisodeTitle = "TITLE 6", EpisodeDate = new DateTime(2018, 7, 18), AuthorId = 5, DoctorId = 6 },
                new Episode { EpisodeId = 7, SeriesNumber = 2, EpisodeNumber = 1, EpisodeType = "TYPE 1", EpisodeTitle = "TITLE 7", EpisodeDate = new DateTime(2018, 7, 18), AuthorId = 6, DoctorId = 7 },
                new Episode { EpisodeId = 8, SeriesNumber = 2, EpisodeNumber = 1, EpisodeType = "TYPE 3", EpisodeTitle = "TITLE 8", EpisodeDate = new DateTime(2018, 7, 18), AuthorId = 8 }
            );

            modelBuilder.Entity<EpisodeCompanion>().HasData(
                new EpisodeCompanion { EpisodeCompanionId = 1, EpisodeId = 1, CompanionId = 1 },
                new EpisodeCompanion { EpisodeCompanionId = 2, EpisodeId = 1, CompanionId = 2 },
                new EpisodeCompanion { EpisodeCompanionId = 3, EpisodeId = 1, CompanionId = 3 },
                new EpisodeCompanion { EpisodeCompanionId = 4, EpisodeId = 1, CompanionId = 4 },
                new EpisodeCompanion { EpisodeCompanionId = 5, EpisodeId = 1, CompanionId = 5 },
                new EpisodeCompanion { EpisodeCompanionId = 6, EpisodeId = 2, CompanionId = 1 },
                new EpisodeCompanion { EpisodeCompanionId = 7, EpisodeId = 2, CompanionId = 2 },
                new EpisodeCompanion { EpisodeCompanionId = 8, EpisodeId = 2, CompanionId = 3 },
                new EpisodeCompanion { EpisodeCompanionId = 9, EpisodeId = 3, CompanionId = 4 },
                new EpisodeCompanion { EpisodeCompanionId = 10, EpisodeId = 3, CompanionId = 3 },
                new EpisodeCompanion { EpisodeCompanionId = 11, EpisodeId = 4, CompanionId = 5 },
                new EpisodeCompanion { EpisodeCompanionId = 12, EpisodeId = 4, CompanionId = 2 },
                new EpisodeCompanion { EpisodeCompanionId = 13, EpisodeId = 5, CompanionId = 1 },
                new EpisodeCompanion { EpisodeCompanionId = 14, EpisodeId = 6, CompanionId = 1 }
            );

            modelBuilder.Entity<EpisodeEnemy>().HasData(
                new EpisodeEnemy { EpisodeEnemyId = 1, EpisodeId = 1, EnemyId = 1 },
                new EpisodeEnemy { EpisodeEnemyId = 2, EpisodeId = 1, EnemyId = 2 },
                new EpisodeEnemy { EpisodeEnemyId = 3, EpisodeId = 1, EnemyId = 3 },
                new EpisodeEnemy { EpisodeEnemyId = 4, EpisodeId = 1, EnemyId = 4 },
                new EpisodeEnemy { EpisodeEnemyId = 5, EpisodeId = 2, EnemyId = 1 },
                new EpisodeEnemy { EpisodeEnemyId = 6, EpisodeId = 2, EnemyId = 2 },
                new EpisodeEnemy { EpisodeEnemyId = 7, EpisodeId = 2, EnemyId = 7 },
                new EpisodeEnemy { EpisodeEnemyId = 8, EpisodeId = 3, EnemyId = 1 },
                new EpisodeEnemy { EpisodeEnemyId = 9, EpisodeId = 4, EnemyId = 1 },
                new EpisodeEnemy { EpisodeEnemyId = 10, EpisodeId = 5, EnemyId = 1 },
                new EpisodeEnemy { EpisodeEnemyId = 11, EpisodeId = 5, EnemyId = 2 },
                new EpisodeEnemy { EpisodeEnemyId = 12, EpisodeId = 6, EnemyId = 2 },
                new EpisodeEnemy { EpisodeEnemyId = 13, EpisodeId = 6, EnemyId = 3 },
                new EpisodeEnemy { EpisodeEnemyId = 14, EpisodeId = 7, EnemyId = 2 },
                new EpisodeEnemy { EpisodeEnemyId = 15, EpisodeId = 7, EnemyId = 3 }
            );

            #endregion

            #region Mapping view

            modelBuilder
                .Entity<ViewEpisodes>(eb =>
                {
                    eb.HasNoKey();
                    eb.ToView("viewEpisodes");
                });

            #endregion
        }
    }
}
