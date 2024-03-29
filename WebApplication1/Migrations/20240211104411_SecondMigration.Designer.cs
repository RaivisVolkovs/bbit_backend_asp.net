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
    [Migration("20240211104411_SecondMigration")]
    partial class SecondMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DzivoklisIedzivotajs", b =>
                {
                    b.Property<Guid>("DzivokliId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IedzivotajiId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("DzivokliId", "IedzivotajiId");

                    b.HasIndex("IedzivotajiId");

                    b.ToTable("DzivoklisIedzivotajs");
                });

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
                            Id = new Guid("012bb24f-b21a-4b26-9d25-d403ed389418"),
                            DzīvojamāPlatība = 60.5,
                            IedzīvotājuSkaits = 2,
                            IstabuSkaits = 3,
                            MājaId = new Guid("e0d14e6e-aa81-4e4d-aa1e-82208e105408"),
                            Numurs = "1",
                            PilnaPlatība = 80.5,
                            Stāvs = 1
                        },
                        new
                        {
                            Id = new Guid("039589bb-829b-4b4c-99ce-0fce21fbadff"),
                            DzīvojamāPlatība = 75.0,
                            IedzīvotājuSkaits = 3,
                            IstabuSkaits = 4,
                            MājaId = new Guid("b0fcd38b-95a3-4d7a-bdc2-b9178f31ccbd"),
                            Numurs = "2",
                            PilnaPlatība = 100.0,
                            Stāvs = 2
                        },
                        new
                        {
                            Id = new Guid("0c474931-16db-476a-8645-6b1f57384eb4"),
                            DzīvojamāPlatība = 45.0,
                            IedzīvotājuSkaits = 1,
                            IstabuSkaits = 2,
                            MājaId = new Guid("e0d14e6e-aa81-4e4d-aa1e-82208e105408"),
                            Numurs = "3",
                            PilnaPlatība = 50.0,
                            Stāvs = 3
                        },
                        new
                        {
                            Id = new Guid("2a43e231-c6f1-4420-af9e-248b0bce22df"),
                            DzīvojamāPlatība = 100.0,
                            IedzīvotājuSkaits = 4,
                            IstabuSkaits = 5,
                            MājaId = new Guid("e0d14e6e-aa81-4e4d-aa1e-82208e105408"),
                            Numurs = "4",
                            PilnaPlatība = 120.0,
                            Stāvs = 4
                        },
                        new
                        {
                            Id = new Guid("2c421cc5-0b42-4063-b80a-88c71c913415"),
                            DzīvojamāPlatība = 65.0,
                            IedzīvotājuSkaits = 2,
                            IstabuSkaits = 3,
                            MājaId = new Guid("b0fcd38b-95a3-4d7a-bdc2-b9178f31ccbd"),
                            Numurs = "5",
                            PilnaPlatība = 85.0,
                            Stāvs = 5
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.Iedzivotajs", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DzimšanasDatums")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DzīvoklisId")
                        .HasColumnType("uniqueidentifier");

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
                            Id = new Guid("29c2999c-0311-4f18-8f8b-fcd72cae016e"),
                            DzimšanasDatums = new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DzīvoklisId = new Guid("012bb24f-b21a-4b26-9d25-d403ed389418"),
                            Email = "janis@gmail.com",
                            PersonasKods = "123456-78910",
                            Telefons = "+371 12345678",
                            Uzvārds = "Bērziņš",
                            Vārds = "Jānis"
                        },
                        new
                        {
                            Id = new Guid("47c72ced-3b1e-4958-a367-77ba3caaeac7"),
                            DzimšanasDatums = new DateTime(1985, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DzīvoklisId = new Guid("012bb24f-b21a-4b26-9d25-d403ed389418"),
                            Email = "anna@inbox.lv",
                            PersonasKods = "223456-78910",
                            Telefons = "+371 87654321",
                            Uzvārds = "Zvaigzne",
                            Vārds = "Anna"
                        },
                        new
                        {
                            Id = new Guid("44709782-b08c-48d4-82d7-7213b4bd8958"),
                            DzimšanasDatums = new DateTime(1990, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DzīvoklisId = new Guid("0c474931-16db-476a-8645-6b1f57384eb4"),
                            Email = "peteris@gmail.com",
                            PersonasKods = "323456-78910",
                            Telefons = "+371 23456789",
                            Uzvārds = "Kalniņš",
                            Vārds = "Pēteris"
                        },
                        new
                        {
                            Id = new Guid("42af43fa-5798-46b7-8edf-23ff44a273a0"),
                            DzimšanasDatums = new DateTime(1992, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DzīvoklisId = new Guid("2a43e231-c6f1-4420-af9e-248b0bce22df"),
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

                    b.Property<string>("Pilsēta")
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
                            Id = new Guid("e0d14e6e-aa81-4e4d-aa1e-82208e105408"),
                            Iela = "Brīvības iela",
                            Numurs = 1,
                            PastaIndekss = "LV-1010",
                            Pilsēta = "Rīga",
                            Valsts = "Latvija"
                        },
                        new
                        {
                            Id = new Guid("b0fcd38b-95a3-4d7a-bdc2-b9178f31ccbd"),
                            Iela = "Lāčplēša iela",
                            Numurs = 2,
                            PastaIndekss = "LV-1011",
                            Pilsēta = "Rīga",
                            Valsts = "Latvija"
                        });
                });

            modelBuilder.Entity("DzivoklisIedzivotajs", b =>
                {
                    b.HasOne("WebApplication1.Models.Dzivoklis", null)
                        .WithMany()
                        .HasForeignKey("DzivokliId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Iedzivotajs", null)
                        .WithMany()
                        .HasForeignKey("IedzivotajiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
                        .WithMany("Dzīvokli")
                        .HasForeignKey("MājaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Māja");
                });

            modelBuilder.Entity("WebApplication1.Models.Maja", b =>
                {
                    b.Navigation("Dzīvokli");
                });
#pragma warning restore 612, 618
        }
    }
}
