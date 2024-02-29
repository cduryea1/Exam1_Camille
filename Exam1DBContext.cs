using System;
using System.Collections.Generic;
using Exam1_CamilleDuryea.Models;
using Microsoft.EntityFrameworkCore;

namespace Exam1_CamilleDuryea.Data;

public partial class Exam1DBContext : DbContext
{
    public Exam1DBContext()
    {
    }

    public Exam1DBContext(DbContextOptions<Exam1DBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Order> Orders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=Exam1.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
