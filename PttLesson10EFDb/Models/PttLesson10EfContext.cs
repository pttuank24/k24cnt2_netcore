using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PttLesson10EFDb.Models;

public partial class PttLesson10EfContext : DbContext
{
    public PttLesson10EfContext()
    {
    }

    public PttLesson10EfContext(DbContextOptions<PttLesson10EfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<PttMember> PttMembers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-ADIKM29;Database=PttLesson10EF;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PttMember>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PttMembe__3214EC074BBE4903");

            entity.ToTable("PttMember");

            entity.Property(e => e.PttEmail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PttFullName).HasMaxLength(50);
            entity.Property(e => e.PttPassword)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PttPhone)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PttUserName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
