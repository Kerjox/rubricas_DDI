﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PracticaExamenEscuela.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EscuelaEntities : DbContext
    {
        public EscuelaEntities()
            : base("name=EscuelaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Asignaturas> Asignaturas { get; set; }
        public virtual DbSet<AsignaturasCursos> AsignaturasCursos { get; set; }
        public virtual DbSet<Cursos> Cursos { get; set; }
        public virtual DbSet<Etapas> Etapas { get; set; }
    }
}
