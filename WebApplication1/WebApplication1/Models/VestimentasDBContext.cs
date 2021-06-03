using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApplication1.Models
{
    public partial class VestimentasDBContext : DbContext
    {
        public VestimentasDBContext()
        {
        }

        public VestimentasDBContext(DbContextOptions<VestimentasDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Local> Locals { get; set; }
        public virtual DbSet<Prendum> Prenda { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=VestimentasDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Local>(entity =>
            {
                entity.HasKey(e => e.IdLocal);

                entity.ToTable("Local");

                entity.Property(e => e.Direccion).HasMaxLength(200);

                entity.Property(e => e.Nombre).HasMaxLength(100);
            });

            modelBuilder.Entity<Prendum>(entity =>
            {
                entity.HasKey(e => e.IdPrenda);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
