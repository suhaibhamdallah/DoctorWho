﻿// <auto-generated />
using System;
using DoctorWho.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DoctorWho.Db.Migrations
{
    [DbContext(typeof(DoctorWhoCoreDbContext))]
    partial class DoctorWhoCoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DoctorWho.Db.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            AuthorName = "Suhaib Hamdallah"
                        },
                        new
                        {
                            AuthorId = 2,
                            AuthorName = "Anas Zakarneh"
                        },
                        new
                        {
                            AuthorId = 3,
                            AuthorName = "Mohammad Abu-Qasedo"
                        },
                        new
                        {
                            AuthorId = 4,
                            AuthorName = "Stephen Hillenburg"
                        },
                        new
                        {
                            AuthorId = 5,
                            AuthorName = "Craig McCracken"
                        },
                        new
                        {
                            AuthorId = 6,
                            AuthorName = "Genndy Tartakovsky"
                        },
                        new
                        {
                            AuthorId = 7,
                            AuthorName = "Alex Hirsch"
                        },
                        new
                        {
                            AuthorId = 8,
                            AuthorName = "Butch Hartman"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Models.Companion", b =>
                {
                    b.Property<int>("CompanionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanionName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("WhoPlayed")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("CompanionId");

                    b.ToTable("Companions");

                    b.HasData(
                        new
                        {
                            CompanionId = 1,
                            CompanionName = "Zaid Nour"
                        },
                        new
                        {
                            CompanionId = 2,
                            CompanionName = "Jweid Hamdallah"
                        },
                        new
                        {
                            CompanionId = 3,
                            CompanionName = "Amjad Salhab"
                        },
                        new
                        {
                            CompanionId = 4,
                            CompanionName = "Osaid Nour"
                        },
                        new
                        {
                            CompanionId = 5,
                            CompanionName = "Yazan Fouqha"
                        },
                        new
                        {
                            CompanionId = 6,
                            CompanionName = "Osaid Hamdallah"
                        },
                        new
                        {
                            CompanionId = 7,
                            CompanionName = "Hasan Khalaf"
                        },
                        new
                        {
                            CompanionId = 8,
                            CompanionName = "Rayan Hamdallah"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Models.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BithDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DoctorName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("DoctorNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("FirstEpisodeDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastEpisodeDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DoctorId");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            DoctorId = 1,
                            BithDate = new DateTime(1962, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Dr. William A. Abdu, M.D, M.S.",
                            DoctorNumber = 1,
                            FirstEpisodeDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 2,
                            BithDate = new DateTime(1962, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Dr. Myles. B. Abbott, M.D.",
                            DoctorNumber = 2,
                            FirstEpisodeDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 3,
                            BithDate = new DateTime(1962, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Dr. Khalid Abbed, M.D.",
                            DoctorNumber = 3,
                            FirstEpisodeDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 4,
                            BithDate = new DateTime(1962, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Dr. Fouad. M. Abbas, M.D.",
                            DoctorNumber = 4,
                            FirstEpisodeDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 5,
                            BithDate = new DateTime(1962, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Dr. Naresh Trehan",
                            DoctorNumber = 5,
                            FirstEpisodeDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 6,
                            BithDate = new DateTime(1962, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Dr. Ahmad Assi",
                            DoctorNumber = 6,
                            FirstEpisodeDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 7,
                            BithDate = new DateTime(1962, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Dr. Laith Sharaqa",
                            DoctorNumber = 7,
                            FirstEpisodeDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 8,
                            BithDate = new DateTime(1962, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Dr. Hamza Nour",
                            DoctorNumber = 8,
                            FirstEpisodeDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Models.Enemy", b =>
                {
                    b.Property<int>("EnemyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(1800)
                        .HasColumnType("nvarchar(1800)");

                    b.Property<string>("EnemyName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("EnemyId");

                    b.ToTable("Enemies");

                    b.HasData(
                        new
                        {
                            EnemyId = 1,
                            Description = "bla bla",
                            EnemyName = "Eric Cartman"
                        },
                        new
                        {
                            EnemyId = 2,
                            Description = "bla bla",
                            EnemyName = "Vicky"
                        },
                        new
                        {
                            EnemyId = 3,
                            Description = "bla bla",
                            EnemyName = "Stewie Griffin"
                        },
                        new
                        {
                            EnemyId = 4,
                            Description = "bla bla",
                            EnemyName = "Maleficent"
                        },
                        new
                        {
                            EnemyId = 5,
                            Description = "bla bla",
                            EnemyName = "Mr. Pickles "
                        },
                        new
                        {
                            EnemyId = 6,
                            Description = "bla bla",
                            EnemyName = "Ahmad Nassar"
                        },
                        new
                        {
                            EnemyId = 7,
                            Description = "bla bla",
                            EnemyName = "Mohammad Domidi"
                        },
                        new
                        {
                            EnemyId = 8,
                            Description = "bla bla",
                            EnemyName = "Ammar Omar"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Models.Episode", b =>
                {
                    b.Property<int>("EpisodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int?>("DoctorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EpisodeDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EpisodeNumber")
                        .HasColumnType("int");

                    b.Property<string>("EpisodeTitle")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("EpisodeType")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Notes")
                        .HasMaxLength(1800)
                        .HasColumnType("nvarchar(1800)");

                    b.Property<int>("SeriesNumber")
                        .HasColumnType("int");

                    b.HasKey("EpisodeId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("DoctorId");

                    b.ToTable("Episodes");

                    b.HasData(
                        new
                        {
                            EpisodeId = 1,
                            AuthorId = 1,
                            DoctorId = 1,
                            EpisodeDate = new DateTime(2018, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeTitle = "TITLE 1",
                            EpisodeType = "TYPE 1",
                            SeriesNumber = 1
                        },
                        new
                        {
                            EpisodeId = 2,
                            AuthorId = 2,
                            DoctorId = 2,
                            EpisodeDate = new DateTime(2018, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeTitle = "TITLE 2",
                            EpisodeType = "TYPE 2",
                            SeriesNumber = 1
                        },
                        new
                        {
                            EpisodeId = 3,
                            AuthorId = 3,
                            DoctorId = 3,
                            EpisodeDate = new DateTime(2018, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeTitle = "TITLE 3",
                            EpisodeType = "TYPE 3",
                            SeriesNumber = 1
                        },
                        new
                        {
                            EpisodeId = 4,
                            AuthorId = 3,
                            DoctorId = 4,
                            EpisodeDate = new DateTime(2018, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeTitle = "TITLE 4",
                            EpisodeType = "TYPE 3",
                            SeriesNumber = 1
                        },
                        new
                        {
                            EpisodeId = 5,
                            AuthorId = 4,
                            DoctorId = 5,
                            EpisodeDate = new DateTime(2018, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeTitle = "TITLE 5",
                            EpisodeType = "TYPE 2",
                            SeriesNumber = 2
                        },
                        new
                        {
                            EpisodeId = 6,
                            AuthorId = 5,
                            DoctorId = 6,
                            EpisodeDate = new DateTime(2018, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeTitle = "TITLE 6",
                            EpisodeType = "TYPE 1",
                            SeriesNumber = 2
                        },
                        new
                        {
                            EpisodeId = 7,
                            AuthorId = 6,
                            DoctorId = 7,
                            EpisodeDate = new DateTime(2018, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeTitle = "TITLE 7",
                            EpisodeType = "TYPE 1",
                            SeriesNumber = 2
                        },
                        new
                        {
                            EpisodeId = 8,
                            AuthorId = 8,
                            EpisodeDate = new DateTime(2018, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeTitle = "TITLE 8",
                            EpisodeType = "TYPE 3",
                            SeriesNumber = 2
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Models.EpisodeCompanion", b =>
                {
                    b.Property<int>("EpisodeCompanionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanionId")
                        .HasColumnType("int");

                    b.Property<int>("EpisodeId")
                        .HasColumnType("int");

                    b.HasKey("EpisodeCompanionId");

                    b.HasIndex("CompanionId");

                    b.HasIndex("EpisodeId");

                    b.ToTable("EpisodeCompanions");

                    b.HasData(
                        new
                        {
                            EpisodeCompanionId = 1,
                            CompanionId = 1,
                            EpisodeId = 1
                        },
                        new
                        {
                            EpisodeCompanionId = 2,
                            CompanionId = 2,
                            EpisodeId = 1
                        },
                        new
                        {
                            EpisodeCompanionId = 3,
                            CompanionId = 3,
                            EpisodeId = 1
                        },
                        new
                        {
                            EpisodeCompanionId = 4,
                            CompanionId = 4,
                            EpisodeId = 1
                        },
                        new
                        {
                            EpisodeCompanionId = 5,
                            CompanionId = 5,
                            EpisodeId = 1
                        },
                        new
                        {
                            EpisodeCompanionId = 6,
                            CompanionId = 1,
                            EpisodeId = 2
                        },
                        new
                        {
                            EpisodeCompanionId = 7,
                            CompanionId = 2,
                            EpisodeId = 2
                        },
                        new
                        {
                            EpisodeCompanionId = 8,
                            CompanionId = 3,
                            EpisodeId = 2
                        },
                        new
                        {
                            EpisodeCompanionId = 9,
                            CompanionId = 4,
                            EpisodeId = 3
                        },
                        new
                        {
                            EpisodeCompanionId = 10,
                            CompanionId = 3,
                            EpisodeId = 3
                        },
                        new
                        {
                            EpisodeCompanionId = 11,
                            CompanionId = 5,
                            EpisodeId = 4
                        },
                        new
                        {
                            EpisodeCompanionId = 12,
                            CompanionId = 2,
                            EpisodeId = 4
                        },
                        new
                        {
                            EpisodeCompanionId = 13,
                            CompanionId = 1,
                            EpisodeId = 5
                        },
                        new
                        {
                            EpisodeCompanionId = 14,
                            CompanionId = 1,
                            EpisodeId = 6
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Models.EpisodeEnemy", b =>
                {
                    b.Property<int>("EpisodeEnemyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EnemyId")
                        .HasColumnType("int");

                    b.Property<int>("EpisodeId")
                        .HasColumnType("int");

                    b.HasKey("EpisodeEnemyId");

                    b.HasIndex("EnemyId");

                    b.HasIndex("EpisodeId");

                    b.ToTable("EpisodeEnemies");

                    b.HasData(
                        new
                        {
                            EpisodeEnemyId = 1,
                            EnemyId = 1,
                            EpisodeId = 1
                        },
                        new
                        {
                            EpisodeEnemyId = 2,
                            EnemyId = 2,
                            EpisodeId = 1
                        },
                        new
                        {
                            EpisodeEnemyId = 3,
                            EnemyId = 3,
                            EpisodeId = 1
                        },
                        new
                        {
                            EpisodeEnemyId = 4,
                            EnemyId = 4,
                            EpisodeId = 1
                        },
                        new
                        {
                            EpisodeEnemyId = 5,
                            EnemyId = 1,
                            EpisodeId = 2
                        },
                        new
                        {
                            EpisodeEnemyId = 6,
                            EnemyId = 2,
                            EpisodeId = 2
                        },
                        new
                        {
                            EpisodeEnemyId = 7,
                            EnemyId = 7,
                            EpisodeId = 2
                        },
                        new
                        {
                            EpisodeEnemyId = 8,
                            EnemyId = 1,
                            EpisodeId = 3
                        },
                        new
                        {
                            EpisodeEnemyId = 9,
                            EnemyId = 1,
                            EpisodeId = 4
                        },
                        new
                        {
                            EpisodeEnemyId = 10,
                            EnemyId = 1,
                            EpisodeId = 5
                        },
                        new
                        {
                            EpisodeEnemyId = 11,
                            EnemyId = 2,
                            EpisodeId = 5
                        },
                        new
                        {
                            EpisodeEnemyId = 12,
                            EnemyId = 2,
                            EpisodeId = 6
                        },
                        new
                        {
                            EpisodeEnemyId = 13,
                            EnemyId = 3,
                            EpisodeId = 6
                        },
                        new
                        {
                            EpisodeEnemyId = 14,
                            EnemyId = 2,
                            EpisodeId = 7
                        },
                        new
                        {
                            EpisodeEnemyId = 15,
                            EnemyId = 3,
                            EpisodeId = 7
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Models.Episode", b =>
                {
                    b.HasOne("DoctorWho.Db.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.HasOne("DoctorWho.Db.Models.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId");

                    b.Navigation("Author");

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("DoctorWho.Db.Models.EpisodeCompanion", b =>
                {
                    b.HasOne("DoctorWho.Db.Models.Companion", "Companion")
                        .WithMany()
                        .HasForeignKey("CompanionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Db.Models.Episode", "Episode")
                        .WithMany()
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Companion");

                    b.Navigation("Episode");
                });

            modelBuilder.Entity("DoctorWho.Db.Models.EpisodeEnemy", b =>
                {
                    b.HasOne("DoctorWho.Db.Models.Enemy", "Enemy")
                        .WithMany()
                        .HasForeignKey("EnemyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Db.Models.Episode", "Episode")
                        .WithMany()
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Enemy");

                    b.Navigation("Episode");
                });
#pragma warning restore 612, 618
        }
    }
}
