using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SellTech.Domain.Entities;

namespace SellTech.Infrastructure.Persistences.Contexts.Configurations
{
    public class TblPosDetalleVentumConfiguration : IEntityTypeConfiguration<TblPosDetalleVentum>
    {
        public void Configure(EntityTypeBuilder<TblPosDetalleVentum> builder)
        {
            builder.HasKey(e => e.PkTblPosDetalleVenta).HasName("PK__TBL_POS___403624DA2038F498");

            builder.ToTable("TBL_POS_DETALLE_VENTA");

            builder.Property(e => e.PkTblPosDetalleVenta).HasColumnName("PK_TBL_POS_DETALLE_VENTA");
            builder.Property(e => e.Cantidad).HasColumnName("CANTIDAD");
            builder.Property(e => e.Descuento)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("DESCUENTO");
            builder.Property(e => e.FechaActualizacionAuditoria).HasColumnName("FECHA_ACTUALIZACION_AUDITORIA");
            builder.Property(e => e.FechaCreacionAuditoria).HasColumnName("FECHA_CREACION_AUDITORIA");
            builder.Property(e => e.FechaEliminacionAuditoria).HasColumnName("FECHA_ELIMINACION_AUDITORIA");
            builder.Property(e => e.FkIdProducto).HasColumnName("FK_ID_PRODUCTO");
            builder.Property(e => e.FkIdVenta).HasColumnName("FK_ID_VENTA");
            builder.Property(e => e.Precio)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("PRECIO");
            builder.Property(e => e.UsuarioActualizacionAuditoria).HasColumnName("USUARIO_ACTUALIZACION_AUDITORIA");
            builder.Property(e => e.UsuarioCreacionAuditoria).HasColumnName("USUARIO_CREACION_AUDITORIA");
            builder.Property(e => e.UsuarioEliminacionAuditoria).HasColumnName("USUARIO_ELIMINACION_AUDITORIA");

            builder.HasOne(d => d.FkIdProductoNavigation).WithMany(p => p.TblPosDetalleVenta)
                .HasForeignKey(d => d.FkIdProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TBL_POS_PRODUCTO_2");

            builder.HasOne(d => d.FkIdVentaNavigation).WithMany(p => p.TblPosDetalleVenta)
                .HasForeignKey(d => d.FkIdVenta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TBL_POS_VENTA");
        }
    }
}
