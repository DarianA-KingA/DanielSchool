using DanielSchool.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielSchool.Infrastructure.Persistence.Contexts
{
    public class ApplicationContext: DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        public DbSet<Asignacion> Asignacion { get; set; }
        public DbSet<Calificacion> Calificacion { get; set; }
        public DbSet<Grado> Grado { get; set; }
        public DbSet<Noticia> Noticia { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region "Tablas"
            modelBuilder.Entity<Asignacion>()
                .ToTable("Asignacion");

            modelBuilder.Entity<Calificacion>()
                .ToTable("Calificacion");

            modelBuilder.Entity<Grado>()
                .ToTable("Grado");

            modelBuilder.Entity<Noticia>()
                .ToTable("Noticia");
            #endregion

            #region "Llaves Primarias"
            modelBuilder.Entity<Asignacion>()
                .HasKey(k => k.Id);

            modelBuilder.Entity<Calificacion>()
                .HasKey(k => k.Id);

            modelBuilder.Entity<Grado>()
                .HasKey(k => k.Id);

            modelBuilder.Entity<Noticia>()
                .HasKey(k => k.Id);
            #endregion
            #region "Relaciones"
            modelBuilder.Entity<Grado>()
                .HasMany<Calificacion>(g =>g.NP_calificacions)
                .WithOne(s=>s.NP_grado)
                .HasForeignKey(g => g.GradoId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Grado>()
                .HasMany<Asignacion>(g => g.NP_asignations)
                .WithOne(s => s.NP_grado)
                .HasForeignKey(g => g.GradoId)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion
            #region "Configuraciones"
            #endregion
        }

    }
}
