using DanielSchool.Core.Application.Enums;
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
            #region "Tablas con datos"
            modelBuilder.Entity<Grado>().HasData(
                new Grado { 
                    Id=1,
                    Name = EnumGrados._4to.ToString().TrimStart('_'),
                    Section = 'A'
                },
                new Grado
                {
                    Id = 2,
                    Name = EnumGrados._4to.ToString().TrimStart('_'),
                    Section = 'B'
                },
                new Grado
                {
                    Id = 3,
                    Name = EnumGrados._5to.ToString().TrimStart('_'),
                    Section = 'A'
                },
                new Grado
                {
                    Id = 4,
                    Name = EnumGrados._5to.ToString().TrimStart('_'),
                    Section = 'B'
                },
                new Grado
                {
                    Id = 5,
                    Name = EnumGrados._6to.ToString().TrimStart('_'),
                    Section = 'A'
                },
                new Grado
                {
                    Id = 6,
                    Name = EnumGrados._6to.ToString().TrimStart('_'),
                    Section = 'B'
                },
                new Grado
                {
                    Id = 7,
                    Name = EnumGrados._7mo.ToString().TrimStart('_'),
                    Section = 'A'
                },
                new Grado
                {
                    Id = 8,
                    Name = EnumGrados._7mo.ToString().TrimStart('_'),
                    Section = 'B'
                },
                new Grado
                {
                    Id = 9,
                    Name = EnumGrados._8vo.ToString().TrimStart('_'),
                    Section = 'A'
                },
                new Grado
                {
                    Id = 10,
                    Name = EnumGrados._8vo.ToString().TrimStart('_'),
                    Section = 'B'
                },
                new Grado
                {
                    Id = 11,
                    Name = EnumGrados._9no.ToString().TrimStart('_'),
                    Section = 'A'
                },
                new Grado
                {
                    Id = 12,
                    Name = EnumGrados._9no.ToString().TrimStart('_'),
                    Section = 'B'

                },
                new Grado
                {
                    Id = 13,
                    Name = EnumGrados._10mo.ToString().TrimStart('_'),
                    Section = 'A'
                },
                new Grado { 
                    Id=14,
                    Name = EnumGrados._10mo.ToString().TrimStart('_'),
                    Section = 'B'
                },
                new Grado
                {
                    Id = 15,
                    Name = EnumGrados._11vo.ToString().TrimStart('_'),
                    Section = 'A'
                },
                new Grado
                {
                    Id = 16,
                    Name = EnumGrados._11vo.ToString().TrimStart('_'),
                    Section = 'B'
                },
                new Grado
                {
                    Id = 17,
                    Name = EnumGrados._12vo.ToString().TrimStart('_'),
                    Section = 'A'
                },
                new Grado
                {
                    Id = 18,
                    Name = EnumGrados._12vo.ToString().TrimStart('_'),
                    Section = 'B'
                }
                );
            #endregion
        }

    }
}
