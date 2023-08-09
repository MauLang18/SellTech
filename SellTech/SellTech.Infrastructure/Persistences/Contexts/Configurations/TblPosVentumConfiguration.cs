using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SellTech.Domain.Entities;

namespace SellTech.Infrastructure.Persistences.Contexts.Configurations
{
    public class TblPosVentumConfiguration : IEntityTypeConfiguration<TblPosVentum>
    {
        public void Configure(EntityTypeBuilder<TblPosVentum> builder)
        {
            builder.HasKey(e => e.PkTblPosVenta).HasName("PK__TBL_POS___F8C98FE86738FC52");

            builder.ToTable("TBL_POS_VENTA");

            builder.Property(e => e.PkTblPosVenta).HasColumnName("PK_TBL_POS_VENTA");
            builder.Property(e => e.Estado).HasColumnName("ESTADO");
            builder.Property(e => e.FechaActualizacionAuditoria).HasColumnName("FECHA_ACTUALIZACION_AUDITORIA");
            builder.Property(e => e.FechaCreacionAuditoria).HasColumnName("FECHA_CREACION_AUDITORIA");
            builder.Property(e => e.FechaEliminacionAuditoria).HasColumnName("FECHA_ELIMINACION_AUDITORIA");
            builder.Property(e => e.FechaVenta).HasColumnName("FECHA_VENTA");
            builder.Property(e => e.FkIdCliente).HasColumnName("FK_ID_CLIENTE");
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

            builder.HasOne(d => d.FkIdClienteNavigation).WithMany(p => p.TblPosVenta)
                .HasForeignKey(d => d.FkIdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TBL_POS_CLIENTE");

            builder.HasOne(d => d.FkIdUsuarioNavigation).WithMany(p => p.TblPosVenta)
                .HasForeignKey(d => d.FkIdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TBL_POS_USUARIO_3");
        }
    }
}
