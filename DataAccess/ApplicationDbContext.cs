using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configuración de la relación uno a muchos
            modelBuilder.Entity<TiposEspecialidad>()
                .HasMany(t => t.ProgramasTitulaciones)
                .WithOne(p => p.Especialidad)
                .HasForeignKey(p => p.EspecialidadId);

            // Relacion ProgramasOfertados => ProgramasTitulacion, OfertaAnual, Universidad
            modelBuilder.Entity<ProgramasTitulacion>()
                .HasMany(p => p.ProgramasOfertados)
                .WithOne(po => po.Programas)
                .HasForeignKey(po => po.ProgramaId);

            modelBuilder.Entity<OfertaAnual>()
                .HasMany(o => o.ProgramasOfertados)
                .WithOne(po => po.Oferta)
                .HasForeignKey(po => po.OfertaId);

            modelBuilder.Entity<Universidad>()
               .HasMany(u => u.ProgramasOfertados)
               .WithOne(po => po.Universidad)
               .HasForeignKey(po => po.UniversidadId);

            //Relacion Persona => EstudiosAcademicos, ExperienciaLaboral, Usuario
            modelBuilder.Entity<EstudiosAcademicos>()
               .HasOne(ea => ea.Persona)
               .WithMany(p => p.EstudiosAcademicos)
               .HasForeignKey(ea => ea.PersonaID);

            modelBuilder.Entity<ExperienciaLaboral>()
                .HasOne(el => el.Persona)
                .WithMany(p => p.ExperienciaLaborals)
                .HasForeignKey(el => el.PersonaID);

            modelBuilder.Entity<Usuario>()
                 .HasOne(u => u.Persona)
                 .WithMany(p => p.Usuario)
                 .HasForeignKey(u => u.PersonaId);

            //Relaciones SolicitudesProgramas => ProgramasOfertados, Persona
            modelBuilder.Entity<ProgramasOfertados>()
                .HasMany(po => po.SolicitudesProgramas)
                .WithOne(sp => sp.ProgramasOfertados)
                .HasForeignKey(sp => sp.ProgramaOfertadoId);
            
            modelBuilder.Entity<Persona>()
                .HasMany(p =>p.SolicitudesProgramas)
                .WithOne(sp => sp.Persona)
                .HasForeignKey(sp => sp.PersonaId);

            //Relacion SolicitudesAceptada => SolicitudesProgramas
            modelBuilder.Entity<SolicitudesProgramas>()
                .HasMany(sp => sp.SolicitudesAceptadas)
                .WithOne(sa => sa.SolicitudesProgramas)
                .HasForeignKey(sp => sp.SolicitudID);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Universidad> Universidad { get; set; }
        public DbSet<ExperienciaLaboral> ExperienciaLaboral { get; set; }
        public DbSet<EstudiosAcademicos> EstudiosAcademicos { get; set; }        
        public DbSet<Rol> Rol { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<OfertaAnual> OfertaAnual { get; set; }
        public DbSet<Persona> Persona { get; set; } //Para la creacion de la tabla
        public DbSet<TiposEspecialidad> TiposEspecialidad { get; set; }
        public DbSet<ProgramasTitulacion> ProgramasTitulacion { get; set; }
        public DbSet<ProgramasOfertados> ProgramasOfertados {get; set;}
        public DbSet<SolicitudesProgramas> SolicitudesProgramas { get; set; }
        public DbSet<SolicitudesAceptadas> SolicitudesAceptadas { get; set; }
    }
}
