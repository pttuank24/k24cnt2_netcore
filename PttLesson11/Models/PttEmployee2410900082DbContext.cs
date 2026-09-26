using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PhamTienTuan2410900082_exam.Models;

public partial class PttEmployee2410900082DbContext : DbContext
{
    public PttEmployee2410900082DbContext()
    {
    }

    public PttEmployee2410900082DbContext(DbContextOptions<PttEmployee2410900082DbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<PttEmployee> PttEmployees { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=DESKTOP-ADIKM29;Database=PttEmployee_2410900082_Db;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PttEmployee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PttEmplo__3214EC07899D7321");

            entity.ToTable("PttEmployee");

            entity.Property(e => e.PttEmail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PttName).HasMaxLength(20);
            entity.Property(e => e.PttPhone)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
