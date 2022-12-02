using DanielSchool.Core.Application.Enums;
using DanielSchool.Core.Domain.Common;
using DanielSchool.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<BaseEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.Created = DateTime.Now;
                        entry.Entity.CreatedBy = "DefaultAppUser";
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModified = DateTime.Now;
                        entry.Entity.LastModifiedBy = "DefaultAppUser";
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }


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
                .HasMany<Asignacion>(g => g.NP_asignations)
                .WithOne(s => s.NP_grado)
                .HasForeignKey(g => g.GradoId)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion
            #region "Configuraciones"
            #endregion
            #region "Tablas con datos"
            #region "Grados por default"
            modelBuilder.Entity<Grado>().HasData(
                new Grado
                {
                    Id = 1,
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
                new Grado
                {
                    Id = 14,
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

            #region "DescCalificacion por default"
            modelBuilder.Entity<Calificacion>().HasData(
                    new Calificacion
                    {
                       Id = 1,
                       Nota = "Iniciado",
                       Comentarios = "N/A",
                       CreatedBy = "Admin",
                       Created = DateTime.Today,
                       Week = 1,
                       Month = 1,
                       StudentUserName = "Estudiante_Usuario",
                       Meta = "Default"
                    },
                    new Calificacion
                    {
                        Id = 2,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 2,
                        Month = 1,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Default"
                    },
                    new Calificacion
                    {
                        Id = 3,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 3,
                        Month = 1,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Default"
                    },
                    new Calificacion
                    {
                        Id = 4,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 4,
                        Month = 1,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Default"
                    },
                    new Calificacion
                    {
                        Id = 5,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 1,
                        Month = 2,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Default"
                    },
                    new Calificacion
                    {
                        Id = 6,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 2,
                        Month = 2,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Default"
                    },
                    new Calificacion
                    {
                        Id = 7,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 3,
                        Month = 2,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Default"
                    },
                    new Calificacion
                    {
                        Id = 8,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 4,
                        Month = 2,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Default"
                    },
                    new Calificacion
                    {
                        Id = 9,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 1,
                        Month = 3,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Default"
                    },
                    new Calificacion
                    {
                        Id = 10,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 2,
                        Month = 3,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Default"
                    },
                    new Calificacion
                    {
                        Id = 11,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 3,
                        Month = 3,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Default"
                    },
                    new Calificacion
                    {
                        Id = 12,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 4,
                        Month = 3,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Default"
                    },
                    new Calificacion
                    {
                        Id = 13,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 1,
                        Month = 4,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Default"
                    },
                    new Calificacion
                    {
                        Id = 14,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 2,
                        Month = 4,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Default"
                    },
                    new Calificacion
                    {
                        Id = 15,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 3,
                        Month = 4,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Default"
                    },
                    new Calificacion
                    {
                        Id = 16,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 4,
                        Month = 4,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Default"
                    },
                    new Calificacion
                    {
                        Id = 17,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 1,
                        Month = 5,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Declarar varibales"
                    },
                    new Calificacion
                    {
                        Id = 18,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 2,
                        Month = 5,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Diagrama de flujo"
                    },
                    new Calificacion
                    {
                        Id = 19,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 3,
                        Month = 5,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Condicional \"if\""
                    },
                    new Calificacion
                    {
                        Id = 20,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 4,
                        Month = 5,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Bubcle \"while\""
                    },
                    new Calificacion
                    {
                        Id = 21,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 1,
                        Month = 6,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Default"
                    },
                    new Calificacion
                    {
                        Id = 22,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 2,
                        Month = 6,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Default"
                    },
                    new Calificacion
                    {
                        Id = 23,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 3,
                        Month = 6,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Default"
                    },
                    new Calificacion
                    {
                        Id = 24,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 4,
                        Month = 6,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Default"
                    },
                    new Calificacion
                    {
                        Id = 25,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 1,
                        Month = 7,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Default"
                    },
                    new Calificacion
                    {
                        Id = 26,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 2,
                        Month = 7,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Default"
                    },
                    new Calificacion
                    {
                        Id = 27,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 3,
                        Month = 7,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Default"
                    },
                    new Calificacion
                    {
                        Id = 28,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 4,
                        Month = 7,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Default"
                    },
                    new Calificacion
                    {
                        Id = 29,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 1,
                        Month = 8,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Default"
                    },
                    new Calificacion
                    {
                        Id = 30,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 2,
                        Month = 8,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Default"
                    },
                    new Calificacion
                    {
                        Id = 31,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 3,
                        Month = 8,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Default"
                    },
                    new Calificacion
                    {
                        Id = 32,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 4,
                        Month = 8,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Default"
                    },
                    new Calificacion
                    {
                        Id = 33,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 1,
                        Month = 9,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Default"
                    },
                    new Calificacion
                    {
                        Id = 34,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 2,
                        Month = 9,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Default"
                    },
                    new Calificacion
                    {
                        Id = 35,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 3,
                        Month = 9,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Default"
                    },
                    new Calificacion
                    {
                        Id = 36,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 4,
                        Month = 9,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Default"
                    },
                    new Calificacion
                    {
                        Id = 37,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 1,
                        Month = 10,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Default"
                    },
                    new Calificacion
                    {
                        Id = 38,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 2,
                        Month = 10,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Default"
                    },
                    new Calificacion
                    {
                        Id = 39,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 3,
                        Month = 10,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Default"
                    },
                    new Calificacion
                    {
                        Id = 40,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 4,
                        Month = 10,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Default"
                    },
                    new Calificacion
                    {
                        Id = 41,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 1,
                        Month = 11,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Default"
                    },
                    new Calificacion
                    {
                        Id = 42,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 2,
                        Month = 11,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Default"
                    },
                    new Calificacion
                    {
                        Id = 43,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 3,
                        Month = 11,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Default"
                    },
                    new Calificacion
                    {
                        Id = 44,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 4,
                        Month = 11,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Default"
                    },
                    new Calificacion
                    {
                        Id = 45,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 1,
                        Month = 12,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Default"
                    },
                    new Calificacion
                    {
                        Id = 46,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 2,
                        Month = 12,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Default"
                    },
                    new Calificacion
                    {
                        Id = 47,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 3,
                        Month = 12,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Default"
                    },
                    new Calificacion
                    {
                        Id = 48,
                        Nota = "Iniciado",
                        Comentarios = "N/A",
                        CreatedBy = "Admin",
                        Created = DateTime.Today,
                        Week = 4,
                        Month = 12,
                        StudentUserName = "Estudiante_Usuario",
                        Meta = "Default"
                    }
                );
            #endregion

            #endregion
        }

    }
}
