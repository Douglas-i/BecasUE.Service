﻿using DataAccess.Entities;
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

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Universidad> Universidad { get; set; }
        public DbSet<ExperienciaLaboral> ExperienciaLaboral { get; set; }
        public DbSet<EstudiosAcademicos> EstudiosAcademicos { get; set; }
        public DbSet<SolicitudesAceptadas> SolicitudesAceptadas { get; set; }    
        public DbSet<Rol> Rol { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<OfertaAnual> OfertaAnual { get; set; }
        public DbSet<Persona> Persona { get; set; } //Para la creacion de la tabla
        public DbSet<TiposEspecialidad> TiposEspecialidad { get; set; }
        public DbSet<ProgramasTitulacion> ProgramasTitulacion { get; set; }
    }
}
