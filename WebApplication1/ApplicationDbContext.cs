using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Net.Sockets;
using WebApplication1.Models;

namespace WebApplication1
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<Maja> Majas { get; set; }
        public DbSet<Dzivoklis> Dzivoklis { get; set; }
        public DbSet<Iedzivotajs> Iedzivotajs { get; set; }
        public DbSet <DzivoklisIedzivotajs> DzivoklisIedzivotaji { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            var maja1 = new Maja { Id = Guid.NewGuid(), Numurs = 1, Iela = "Brīvības iela", Pilseta = "Rīga", Valsts = "Latvija", PastaIndekss = "LV-1010" };
            var maja2 = new Maja { Id = Guid.NewGuid(), Numurs = 2, Iela = "Lāčplēša iela", Pilseta = "Rīga", Valsts = "Latvija", PastaIndekss = "LV-1011" };


            var dzivoklis1 = new Dzivoklis { Id = Guid.NewGuid(), MajaId = maja1.Id, Numurs = "1", Stavs = 1, IstabuSkaits = 3, IedzivotajuSkaits = 2, PilnaPlatiba = 80.5, DzivojamaPlatiba = 60.5 };
            var dzivoklis2 = new Dzivoklis { Id = Guid.NewGuid(), MajaId = maja2.Id, Numurs = "2", Stavs = 2, IstabuSkaits = 4, IedzivotajuSkaits = 3, PilnaPlatiba = 100.0, DzivojamaPlatiba = 75.0 };
            var dzivoklis3 = new Dzivoklis { Id = Guid.NewGuid(), MajaId = maja1.Id, Numurs = "3", Stavs = 3, IstabuSkaits = 2, IedzivotajuSkaits = 1, PilnaPlatiba = 50.0, DzivojamaPlatiba = 45.0 };
            var dzivoklis4 = new Dzivoklis { Id = Guid.NewGuid(), MajaId = maja1.Id, Numurs = "4", Stavs = 4, IstabuSkaits = 5, IedzivotajuSkaits = 4, PilnaPlatiba = 120.0, DzivojamaPlatiba = 100.0 };
            var dzivoklis5 = new Dzivoklis { Id = Guid.NewGuid(), MajaId = maja2.Id, Numurs = "5", Stavs = 5, IstabuSkaits = 3, IedzivotajuSkaits = 2, PilnaPlatiba = 85.0, DzivojamaPlatiba = 65.0 };

            var iedzivotajs1 = new Iedzivotajs { Id = Guid.NewGuid(), Vards = "Jānis", Uzvards = "Bērziņš", PersonasKods = "123456-78910", DzimsanasDatums = new DateTime(1980, 1, 1), Telefons = "+371 12345678", Email = "janis@gmail.com" };
            var iedzivotajs2 = new Iedzivotajs { Id = Guid.NewGuid(), Vards = "Anna", Uzvards = "Zvaigzne", PersonasKods = "223456-78910", DzimsanasDatums = new DateTime(1985, 2, 2), Telefons = "+371 87654321", Email = "anna@inbox.lv" };
            var iedzivotajs3 = new Iedzivotajs { Id = Guid.NewGuid(), Vards = "Pēteris", Uzvards = "Kalniņš", PersonasKods = "323456-78910", DzimsanasDatums = new DateTime(1990, 3, 3), Telefons = "+371 23456789", Email = "peteris@gmail.com" };
            var iedzivotajs4 = new Iedzivotajs { Id = Guid.NewGuid(), Vards = "Līga", Uzvards = "Liepiņa", PersonasKods = "423456-78910", DzimsanasDatums = new DateTime(1992, 4, 4), Telefons = "+371 34567890", Email = "liga@inbox.lv" };

            var dzivoklisIedzivotajs1 = new DzivoklisIedzivotajs { Id = Guid.NewGuid(), DzivoklisId = dzivoklis1.Id, IedzivotajsId = iedzivotajs1.Id, IsOwner = true };
            var dzivoklisIedzivotajs2 = new DzivoklisIedzivotajs { Id = Guid.NewGuid(), DzivoklisId = dzivoklis1.Id, IedzivotajsId = iedzivotajs2.Id, IsOwner = false };
            var dzivoklisIedzivotajs3 = new DzivoklisIedzivotajs { Id = Guid.NewGuid(), DzivoklisId = dzivoklis2.Id, IedzivotajsId = iedzivotajs1.Id, IsOwner = true };
            var dzivoklisIedzivotajs4 = new DzivoklisIedzivotajs { Id = Guid.NewGuid(), DzivoklisId = dzivoklis3.Id, IedzivotajsId = iedzivotajs1.Id, IsOwner = false };


            modelBuilder.Entity<Maja>().HasData(maja1, maja2);
            modelBuilder.Entity<Dzivoklis>().HasData(dzivoklis1, dzivoklis2, dzivoklis3, dzivoklis4, dzivoklis5);
            modelBuilder.Entity<Iedzivotajs>().HasData(iedzivotajs1, iedzivotajs2, iedzivotajs3, iedzivotajs4);
            modelBuilder.Entity<DzivoklisIedzivotajs>().HasData(dzivoklisIedzivotajs1, dzivoklisIedzivotajs2, dzivoklisIedzivotajs3, dzivoklisIedzivotajs4);

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Dzivoklis>()
            .HasMany(e => e.Iedzivotaji)
            .WithMany(e => e.Dzivokli)
            .UsingEntity<DzivoklisIedzivotajs>();

        }

    }

}
