﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProjetoAPItarde.ORM;

public partial class BdEmpresaTardeContext : DbContext
{
    public BdEmpresaTardeContext()
    {
    }

    public BdEmpresaTardeContext(DbContextOptions<BdEmpresaTardeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TbFuncionario> TbFuncionarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAB205_13\\SQLEXPRESS;Database=bd_EmpresaTarde;User Id=adminTarde;Password=admin;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TbFuncionario>(entity =>
        {
            entity.ToTable("Tb_Funcionario");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Foto).HasColumnName("foto");
            entity.Property(e => e.Idade).HasColumnName("idade");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
