using BlogPosts_SQL_EntityFramework.Models; // <-- ajusta el namespace
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BlogPosts_SQL_EntityFramework.Data
{
    public class CrudWindowsFormContext : DbContext
    {
        public DbSet<Persona> Personas => Set<Persona>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // USA TU SQL SERVER EXPRESS Y TU BD
                optionsBuilder.UseSqlServer(
                    "Data Source=LAPTOP-NICO\\SQLEXPRESS;Initial Catalog=CrudWindowsForm;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Nombre).HasMaxLength(100);
                entity.Property(e => e.NumTelefono).HasMaxLength(50);
                entity.Property(e => e.Mail).HasMaxLength(100);
            });
        }
    }
}
