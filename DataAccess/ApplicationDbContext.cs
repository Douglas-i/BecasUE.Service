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

        public DbSet<Candidato> Candidato { get; set; } //Para la creacion de la tabla
        public DbSet<Universidad> Universidad { get; set; }

        public DbSet<ExperienciaLaboral> ExperienciaLaboral{ get; set; }

        public DbSet<EstudiosAcademicos> EstudiosAcademicos { get; set; }


    }
}