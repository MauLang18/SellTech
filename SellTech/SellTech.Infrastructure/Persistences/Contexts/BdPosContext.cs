using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using SellTech.Domain.Entities;

namespace SellTech.Infrastructure.Persistences.Contexts;

public partial class BdPosContext : DbContext
{
    public BdPosContext()
    {
    }

    public BdPosContext(DbContextOptions<BdPosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblPosCategorium> TblPosCategoria { get; set; }

    public virtual DbSet<TblPosCliente> TblPosClientes { get; set; }

    public virtual DbSet<TblPosCompra> TblPosCompras { get; set; }

    public virtual DbSet<TblPosDepartamento> TblPosDepartamentos { get; set; }

    public virtual DbSet<TblPosDetalleCompra> TblPosDetalleCompras { get; set; }

    public virtual DbSet<TblPosDetalleVentum> TblPosDetalleVenta { get; set; }

    public virtual DbSet<TblPosDistricto> TblPosDistrictos { get; set; }

    public virtual DbSet<TblPosEmpresa> TblPosEmpresas { get; set; }

    public virtual DbSet<TblPosMenu> TblPosMenus { get; set; }

    public virtual DbSet<TblPosMenuRol> TblPosMenuRols { get; set; }

    public virtual DbSet<TblPosProducto> TblPosProductos { get; set; }

    public virtual DbSet<TblPosProveedor> TblPosProveedors { get; set; }

    public virtual DbSet<TblPosProvincium> TblPosProvincia { get; set; }

    public virtual DbSet<TblPosRol> TblPosRols { get; set; }

    public virtual DbSet<TblPosRolUsuario> TblPosRolUsuarios { get; set; }

    public virtual DbSet<TblPosSucursal> TblPosSucursals { get; set; }

    public virtual DbSet<TblPosTipoDocumento> TblPosTipoDocumentos { get; set; }

    public virtual DbSet<TblPosUsuario> TblPosUsuarios { get; set; }

    public virtual DbSet<TblPosUsuarioSucursal> TblPosUsuarioSucursals { get; set; }

    public virtual DbSet<TblPosVentum> TblPosVenta { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasAnnotation("Relational.Collaction", "Modern_Spanish_CI_AS");

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
