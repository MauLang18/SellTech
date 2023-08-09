using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SellTech.Domain.Entities;

namespace SellTech.Infrastructure.Persistences.Contexts.Configurations
{
    public class TblPosDetalleCompraConfiguration : IEntityTypeConfiguration<TblPosDetalleCompra>
    {
        public void Configure(EntityTypeBuilder<TblPosDetalleCompra> builder)
        {
            builder.HasKey(e => e.PkTblPosDetalleCompra).HasName("PK__TBL_POS___65C732916557E9EF");

            builder.ToTable("TBL_POS_DETALLE_COMPRA");

            builder.Property(e => e.PkTblPosDetalleCompra).HasColumnName("PK_TBL_POS_DETALLE_COMPRA");
            builder.Property(e => e.Cantidad).HasColumnName("CANTIDAD");
            builder.Property(e => e.FechaActualizacionAuditoria).HasColumnName("FECHA_ACTUALIZACION_AUDITORIA");
            builder.Property(e => e.FechaCreacionAuditoria).HasColumnName("FECHA_CREACION_AUDITORIA");
            builder.Property(e => e.FechaEliminacionAuditoria).HasColumnName("FECHA_ELIMINACION_AUDITORIA");
            builder.Property(e => e.FkIdCompra).HasColumnName("FK_ID_COMPRA");
            builder.Property(e => e.FkIdProducto).HasColumnName("FK_ID_PRODUCTO");
            builder.Property(e => e.Precio)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("PRECIO");
            builder.Property(e => e.UsuarioActualizacionAuditoria).HasColumnName("USUARIO_ACTUALIZACION_AUDITORIA");
            builder.Property(e => e.UsuarioCreacionAuditoria).HasColumnName("USUARIO_CREACION_AUDITORIA");
            builder.Property(e => e.UsuarioEliminacionAuditoria).HasColumnName("USUARIO_ELIMINACION_AUDITORIA");

            builder.HasOne(d => d.FkIdCompraNavigation).WithMany(p => p.TblPosDetalleCompras)
                .HasForeignKey(d => d.FkIdCompra)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TBL_POS_COMPRA");

            builder.HasOne(d => d.FkIdProductoNavigation).WithMany(p => p.TblPosDetalleCompras)
                .HasForeignKey(d => d.FkIdProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TBL_POS_PRODUCTO");
        }
    }
}
