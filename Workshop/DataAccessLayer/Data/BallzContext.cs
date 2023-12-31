﻿using System;
using System.Collections.Generic;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Data;

public partial class BallzContext : DbContext
{
    public BallzContext()
    {
    }

    public BallzContext(DbContextOptions<BallzContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ChristmasBall> ChristmasBalls { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("data source = .\\SQLEXPRESS; Database = BALLZ; encrypt = false; Trusted_Connection = true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChristmasBall>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Christma__3214EC07A11BBCE2");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
