using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DbFirst.Models;

public partial class LegacyContext : DbContext
{
    public LegacyContext()
    {
    }

    public LegacyContext(DbContextOptions<LegacyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Player> Players { get; set; }

    public virtual DbSet<Team> Teams { get; set; }

    public virtual DbSet<Trainer> Trainers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DIM\\SQLEXPRESS;DataBase=lesson19;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Command Timeout=0");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Player>(entity =>
        {
            entity.HasKey(e => e.PlayerId).HasName("PK__Players__4A4E74C80F542638");

            entity.ToTable(tb => tb.HasTrigger("Salary_Calculation_Update_Insert"));

            entity.Property(e => e.PlayerId).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.HasOne(d => d.Team).WithMany(p => p.Players)
                .HasForeignKey(d => d.TeamId)
                .HasConstraintName("FK_Players_Teams");
        });

        modelBuilder.Entity<Team>(entity =>
        {
            entity.HasKey(e => e.TeamId).HasName("PK__Teams__123AE799AF0BEA1D");

            entity.Property(e => e.TeamId).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .IsUnicode(false);

            entity.HasOne(d => d.Trainer).WithMany(p => p.Teams)
                .HasForeignKey(d => d.TrainerId)
                .HasConstraintName("FK__Teams__TrainerId__71D1E811");
        });

        modelBuilder.Entity<Trainer>(entity =>
        {
            entity.HasKey(e => e.TrainerId).HasName("PK__Trainers__366A1A7C3AEB03F8");

            entity.Property(e => e.TrainerId).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(32)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
