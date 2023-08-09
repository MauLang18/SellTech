using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SellTech.Domain.Entities;

namespace SellTech.Infrastructure.Persistences.Contexts.Configurations
{
    public class TblPosCompraConfiguration : IEntityTypeConfiguration<TblPosCompra>
    {
        public void Configure(EntityTypeBuilder<TblPosCompra> builder)
        {
            builder.HasKey(e => e.PkTblPosCompra).HasName("PK__TBL_POS___3C267C23A24A43EE");

            builder.ToTable("TBL_POS_COMPRA");

            builder.Property(e => e.PkTblPosCompra).HasColumnName("PK_TBL_POS_COMPRA");
            builder.Property(e => e.Estado).HasColumnName("ESTADO");
            builder.Property(e => e.FechaActualizacionAuditoria).HasColumnName("FECHA_ACTUALIZACION_AUDITORIA");
            builder.Property(e => e.FechaCompra).HasColumnName("FECHA_COMPRA");
            builder.Property(e => e.FechaCreacionAuditoria).HasColumnName("FECHA_CREACION_AUDITORIA");
            builder.Property(e => e.FechaEliminacionAuditoria).HasColumnName("FECHA_ELIMINACION_AUDITORIA");
            builder.Property(e => e.FkIdProveedor).HasColumnName("FK_ID_PROVEEDOR");
            builder.Property(e => e.FkIdUsuario).HasColumnName("FK_ID_USUARIO");
            builder.Property(e => e.Impuesto)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("IMPUESTO");
            builder.Property(e => e.Total)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("TOTAL");
            builder.Property(e => e.UsuarioActualizacionAuditoria).HasColumnName("USUARIO_ACTUALIZACION_AUDITORIA");
            builder.Property(e => e.UsuarioCreacionAuditoria).HasColumnName("USUARIO_CREACION_AUDITORIA");
            builder.Property(e => e.UsuarioEliminacionAuditoria).HasColumnName("USUARIO_ELIMINACION_AUDITORIA");

            builder.HasOne(d => d.FkIdProveedorNavigation).WithMany(p => p.TblPosCompras)
                .HasForeignKey(d => d.FkIdProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TBL_POS_PROVEEDOR_2");

            builder.HasOne(d => d.FkIdUsuarioNavigation).WithMany(p => p.TblPosCompras)
                .HasForeignKey(d => d.FkIdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TBL_POS_USUARIO_2");
        }
    }
}
