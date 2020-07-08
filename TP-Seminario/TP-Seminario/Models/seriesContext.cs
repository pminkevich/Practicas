using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TP_Seminario.Models
{
    public partial class seriesContext : DbContext
    {
        public seriesContext()
        {
        }

        public seriesContext(DbContextOptions<seriesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Capitulos> Capitulos { get; set; }
        public virtual DbSet<Listseries> Listseries { get; set; }
        public virtual DbSet<Tiposerie> Tiposerie { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=series;User id=sa;Password=mmabhqGJ19;MultipleActiveResultSets=True;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Capitulos>(entity =>
            {
                entity.ToTable("capitulos");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasViewColumnName("id");

                entity.Property(e => e.Capitulo)
                    .HasColumnName("capitulo")
                    .HasViewColumnName("capitulo");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasViewColumnName("descripcion")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Idserie)
                    .HasColumnName("idserie")
                    .HasViewColumnName("idserie");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasColumnName("titulo")
                    .HasViewColumnName("titulo")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url")
                    .HasViewColumnName("url")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.Listseries)
                    .WithMany(p => p.Capitulos)
                    .HasForeignKey(x => x.Idserie)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_capitulos_seri");
            });

            modelBuilder.Entity<Listseries>(entity =>
            {
                entity.ToTable("listseries");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasViewColumnName("id");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasViewColumnName("descripcion")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Idtipo)
                    .HasColumnName("idtipo")
                    .HasViewColumnName("idtipo");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasViewColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tapa)
                   .IsRequired()
                   .HasColumnName("tapa")
                   .HasViewColumnName("tapa")
                   .HasMaxLength(150)
                   .IsUnicode(false);

                entity.Property(e => e.Puntos)
                    .HasColumnName("puntos")
                    .HasViewColumnName("puntos");

                entity.Property(e => e.Vistas)
                    .HasColumnName("vistas")
                    .HasViewColumnName("vistas");

                entity.HasOne(d => d.Tiposerie)
                    .WithMany(p => p.Listseries)
                    .HasForeignKey(x => x.Idtipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_listseries_tipo");



            });

            modelBuilder.Entity<Tiposerie>(entity =>
            {
                entity.ToTable("tiposerie");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasViewColumnName("id");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("tipo")
                    .HasViewColumnName("tipo")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
