using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SellTech.Domain.Entities;

namespace SellTech.Infrastructure.Persistences.Contexts.Configurations
{
    public class TblPosProductoConfiguration : IEntityTypeConfiguration<TblPosProducto>
    {
        public void Configure(EntityTypeBuilder<TblPosProducto> builder)
        {
            builder.HasKey(e => e.PkTblPosProducto).HasName("PK__TBL_POS___F3950838C0AC59AC");

            builder.ToTable("TBL_POS_PRODUCTO");

            builder.Property(e => e.PkTblPosProducto).HasColumnName("PK_TBL_POS_PRODUCTO");
            builder.Property(e => e.Codigo).HasColumnName("CODIGO");
            builder.Property(e => e.Estado).HasColumnName("ESTADO");
            builder.Property(e => e.FechaActualizacionAuditoria).HasColumnName("FECHA_ACTUALIZACION_AUDITORIA");
            builder.Property(e => e.FechaCreacionAuditoria).HasColumnName("FECHA_CREACION_AUDITORIA");
            builder.Property(e => e.FechaEliminacionAuditoria).HasColumnName("FECHA_ELIMINACION_AUDITORIA");
            builder.Property(e => e.FkIdCategoria).HasColumnName("FK_ID_CATEGORIA");
            builder.Property(e => e.FkIdProveedor).HasColumnName("FK_ID_PROVEEDOR");
            builder.Property(e => e.Imagen).HasColumnName("IMAGEN");
            builder.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("NOMBRE");
            builder.Property(e => e.Precio)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("PRECIO");
            builder.Property(e => e.Stock).HasColumnName("STOCK");
            builder.Property(e => e.UsuarioActualizacionAuditoria).HasColumnName("USUARIO_ACTUALIZACION_AUDITORIA");
            builder.Property(e => e.UsuarioCreacionAuditoria).HasColumnName("USUARIO_CREACION_AUDITORIA");
            builder.Property(e => e.UsuarioEliminacionAuditoria).HasColumnName("USUARIO_ELIMINACION_AUDITORIA");

            builder.HasOne(d => d.FkIdCategoriaNavigation).WithMany(p => p.TblPosProductos)
                .HasForeignKey(d => d.FkIdCategoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TBL_POS_CATEGORIA");

            builder.HasOne(d => d.FkIdProveedorNavigation).WithMany(p => p.TblPosProductos)
                .HasForeignKey(d => d.FkIdProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TBL_POS_PROVEEDOR");
        }
    }
}
