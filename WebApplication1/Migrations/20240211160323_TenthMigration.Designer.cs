﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240211160323_TenthMigration")]
    partial class TenthMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("WebApplication1.Models.Dzivoklis", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("DzīvojamāPlatība")
                        .HasColumnType("float");

                    b.Property<int>("IedzīvotājuSkaits")
                        .HasColumnType("int");

                    b.Property<int>("IstabuSkaits")
                        .HasColumnType("int");

                    b.Property<Guid>("MājaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Numurs")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PilnaPlatība")
                        .HasColumnType("float");

                    b.Property<int>("Stāvs")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MājaId");

                    b.ToTable("Dzivoklis");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f9be9311-fb0f-4a66-ad86-5f8b561deb90"),
                            DzīvojamāPlatība = 60.5,
                            IedzīvotājuSkaits = 2,
                            IstabuSkaits = 3,
                            MājaId = new Guid("83b51930-e6b7-462a-ae56-26592e479997"),
                            Numurs = "1",
                            PilnaPlatība = 80.5,
                            Stāvs = 1
                        },
                        new
                        {
                            Id = new Guid("94438f34-c1f7-4738-9828-8e6095da10d0"),
                            DzīvojamāPlatība = 75.0,
                            IedzīvotājuSkaits = 3,
                            IstabuSkaits = 4,
                            MājaId = new Guid("4e702613-344b-4ca0-92bd-d36d68d8d3bb"),
                            Numurs = "2",
                            PilnaPlatība = 100.0,
                            Stāvs = 2
                        },
                        new
                        {
                            Id = new Guid("28edc461-47d2-4a65-a851-908e45c5cb2b"),
                            DzīvojamāPlatība = 45.0,
                            IedzīvotājuSkaits = 1,
                            IstabuSkaits = 2,
                            MājaId = new Guid("83b51930-e6b7-462a-ae56-26592e479997"),
                            Numurs = "3",
                            PilnaPlatība = 50.0,
                            Stāvs = 3
                        },
                        new
                        {
                            Id = new Guid("d6ff55ce-5bd4-4100-93e1-08dbf9a3b94e"),
                            DzīvojamāPlatība = 100.0,
                            IedzīvotājuSkaits = 4,
                            IstabuSkaits = 5,
                            MājaId = new Guid("83b51930-e6b7-462a-ae56-26592e479997"),
                            Numurs = "4",
                            PilnaPlatība = 120.0,
                            Stāvs = 4
                        },
                        new
                        {
                            Id = new Guid("e3824036-e427-41c5-9080-ed5e8832d413"),
                            DzīvojamāPlatība = 65.0,
                            IedzīvotājuSkaits = 2,
                            IstabuSkaits = 3,
                            MājaId = new Guid("4e702613-344b-4ca0-92bd-d36d68d8d3bb"),
                            Numurs = "5",
                            PilnaPlatība = 85.0,
                            Stāvs = 5
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.DzivoklisIedzivotajs", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DzivoklisId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IedzivotajsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsOwner")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("DzivoklisId");

                    b.HasIndex("IedzivotajsId");

                    b.ToTable("DzivoklisIedzivotaji");

                    b.HasData(
                        new
                        {
                            Id = new Guid("269e8965-b32e-4f32-87d1-e8b787a3e2b1"),
                            DzivoklisId = new Guid("f9be9311-fb0f-4a66-ad86-5f8b561deb90"),
                            IedzivotajsId = new Guid("3996b39f-eaeb-40d0-9a49-9789303633e0"),
                            IsOwner = true
                        },
                        new
                        {
                            Id = new Guid("6f760325-6309-44f5-b13d-55aa7167a843"),
                            DzivoklisId = new Guid("f9be9311-fb0f-4a66-ad86-5f8b561deb90"),
                            IedzivotajsId = new Guid("52d10a1f-c772-4537-858c-3a763814bcc1"),
                            IsOwner = false
                        },
                        new
                        {
                            Id = new Guid("7e381743-25e9-40f9-86ac-0b34f33650ce"),
                            DzivoklisId = new Guid("94438f34-c1f7-4738-9828-8e6095da10d0"),
                            IedzivotajsId = new Guid("3996b39f-eaeb-40d0-9a49-9789303633e0"),
                            IsOwner = true
                        },
                        new
                        {
                            Id = new Guid("4f43c72e-f040-47a1-869d-dc97a073a12e"),
                            DzivoklisId = new Guid("28edc461-47d2-4a65-a851-908e45c5cb2b"),
                            IedzivotajsId = new Guid("3996b39f-eaeb-40d0-9a49-9789303633e0"),
                            IsOwner = false
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.Iedzivotajs", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DzimšanasDatums")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonasKods")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefons")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Uzvārds")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vārds")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Iedzivotajs");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3996b39f-eaeb-40d0-9a49-9789303633e0"),
                            DzimšanasDatums = new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "janis@gmail.com",
                            PersonasKods = "123456-78910",
                            Telefons = "+371 12345678",
                            Uzvārds = "Bērziņš",
                            Vārds = "Jānis"
                        },
                        new
                        {
                            Id = new Guid("52d10a1f-c772-4537-858c-3a763814bcc1"),
                            DzimšanasDatums = new DateTime(1985, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "anna@inbox.lv",
                            PersonasKods = "223456-78910",
                            Telefons = "+371 87654321",
                            Uzvārds = "Zvaigzne",
                            Vārds = "Anna"
                        },
                        new
                        {
                            Id = new Guid("78cdec54-9f51-4208-89b6-b7925d5afbf6"),
                            DzimšanasDatums = new DateTime(1990, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "peteris@gmail.com",
                            PersonasKods = "323456-78910",
                            Telefons = "+371 23456789",
                            Uzvārds = "Kalniņš",
                            Vārds = "Pēteris"
                        },
                        new
                        {
                            Id = new Guid("a4d351a9-fd2d-4f6c-8903-ef0382f5a326"),
                            DzimšanasDatums = new DateTime(1992, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "liga@inbox.lv",
                            PersonasKods = "423456-78910",
                            Telefons = "+371 34567890",
                            Uzvārds = "Liepiņa",
                            Vārds = "Līga"
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.Maja", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Iela")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Numurs")
                        .HasColumnType("int");

                    b.Property<string>("PastaIndekss")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pilseta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Valsts")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Majas");

                    b.HasData(
                        new
                        {
                            Id = new Guid("83b51930-e6b7-462a-ae56-26592e479997"),
                            Iela = "Brīvības iela",
                            Numurs = 1,
                            PastaIndekss = "LV-1010",
                            Pilseta = "Rīga",
                            Valsts = "Latvija"
                        },
                        new
                        {
                            Id = new Guid("4e702613-344b-4ca0-92bd-d36d68d8d3bb"),
                            Iela = "Lāčplēša iela",
                            Numurs = 2,
                            PastaIndekss = "LV-1011",
                            Pilseta = "Rīga",
                            Valsts = "Latvija"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication1.Models.Dzivoklis", b =>
                {
                    b.HasOne("WebApplication1.Models.Maja", "Māja")
                        .WithMany()
                        .HasForeignKey("MājaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Māja");
                });

            modelBuilder.Entity("WebApplication1.Models.DzivoklisIedzivotajs", b =>
                {
                    b.HasOne("WebApplication1.Models.Dzivoklis", "Dzivoklis")
                        .WithMany()
                        .HasForeignKey("DzivoklisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Iedzivotajs", "Iedzivotajs")
                        .WithMany()
                        .HasForeignKey("IedzivotajsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dzivoklis");

                    b.Navigation("Iedzivotajs");
                });
#pragma warning restore 612, 618
        }
    }
}
