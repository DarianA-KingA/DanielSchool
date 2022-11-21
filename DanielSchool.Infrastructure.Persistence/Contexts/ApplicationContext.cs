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
        public DbSet<DescCalificacion> DescCalificacion { get; set; }
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
            #region "Calificacion por default"
            modelBuilder.Entity<Calificacion>().HasData(
                new Calificacion { 
                    Id = 1,
                    Agosto = "1,2,3,4",
                    Septiembre = "5,6,7,8",
                    Octubre = "9,10,11,12",
                    Noviembre = "13,14,15,16",
                    Diciembre = "17,18,19,20",
                    Enero = "21,22,23,24",
                    Frebrero = "25,26,27,28",
                    Marzo = "29,30,31,32",
                    Abril = "33,34,35,36",
                    Mayo = "37,38,39,40",
                    Junio = "41,42,43,44",
                    Julio = "45,46,47,48",
                    CreatedBy ="Admin",
                    Created = DateTime.Today,
                    StudentId = "Estudiante_Usuario"
                }
                );
            #endregion
            #region "DescCalificacion por default"
            modelBuilder.Entity<DescCalificacion>().HasData(
                new DescCalificacion { 
                    Id = 1,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification =1
                },
                new DescCalificacion
                {
                    Id = 2,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1

                },
                new DescCalificacion { 
                    Id = 3,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1
                },
                new DescCalificacion
                {
                    Id = 4,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1
                },
                new DescCalificacion
                {
                    Id = 5,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1
                },
                new DescCalificacion
                {
                    Id = 6,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1
                },
                new DescCalificacion
                {
                    Id = 7,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1
                },
                new DescCalificacion
                {
                    Id = 8,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1
                },
                new DescCalificacion
                {
                    Id = 9,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1
                },
                new DescCalificacion
                {
                    Id = 10,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1
                },
                new DescCalificacion
                {
                    Id = 11,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1
                },
                new DescCalificacion
                {
                    Id = 12,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1
                },
                new DescCalificacion
                {
                    Id = 13,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1
                },
                new DescCalificacion
                {
                    Id = 14,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1
                },
                new DescCalificacion
                {
                    Id = 15,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1
                },
                new DescCalificacion
                {
                    Id = 16,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1
                },
                new DescCalificacion
                {
                    Id = 17,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1
                },
                new DescCalificacion
                {
                    Id = 18,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1
                },
                new DescCalificacion
                {
                    Id = 19,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1
                }, 
                new DescCalificacion
                {
                    Id = 20,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1
                },
                new DescCalificacion
                {
                    Id = 21,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1
                },
                new DescCalificacion
                {
                    Id = 22,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1
                },
                new DescCalificacion
                {
                    Id = 23,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1
                },
                new DescCalificacion
                {
                    Id = 24,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1
                },
                new DescCalificacion
                {
                    Id = 25,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1
                },
                new DescCalificacion
                {
                    Id = 26,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1
                },
                new DescCalificacion
                {
                    Id = 27,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1
                },
                new DescCalificacion
                {
                    Id = 28,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1
                },
                new DescCalificacion
                {
                    Id = 29,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1
                },
                new DescCalificacion
                {
                    Id = 30,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1
                },
                new DescCalificacion
                {
                    Id = 31,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1
                },
                new DescCalificacion
                {
                    Id = 32,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1
                },
                new DescCalificacion
                {
                    Id = 33,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1
                },
                new DescCalificacion
                {
                    Id = 34,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1
                },
                new DescCalificacion
                {
                    Id = 35,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1
                },
                new DescCalificacion
                {
                    Id = 36,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1
                },
                new DescCalificacion
                {
                    Id = 37,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1
                },
                new DescCalificacion
                {
                    Id = 38,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1
                },
                new DescCalificacion
                {
                    Id = 39,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1
                },
                new DescCalificacion
                {
                    Id = 40,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1
                },
                new DescCalificacion
                {
                    Id = 41,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1
                },
                new DescCalificacion
                {
                    Id = 42,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1
                },
                new DescCalificacion
                {
                    Id = 43,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1
                },
                new DescCalificacion
                {
                    Id = 44,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1
                },
                new DescCalificacion
                {
                    Id = 45,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1
                },
                new DescCalificacion
                {
                    Id = 46,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1
                },
                new DescCalificacion
                {
                    Id = 47,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1
                },
                new DescCalificacion
                {
                    Id = 48,
                    Nota = 100,
                    PuntosExtras = 0,
                    Comentarios = "N/A",
                    CreatedBy = "Admin",
                    Created = DateTime.Today,
                    IdCalification = 1
                }
                );
            #endregion

            #endregion
        }

    }
}
