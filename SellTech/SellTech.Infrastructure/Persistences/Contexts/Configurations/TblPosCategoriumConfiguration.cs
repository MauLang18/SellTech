using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SellTech.Domain.Entities;

namespace SellTech.Infrastructure.Persistences.Contexts.Configurations
{
    public class TblPosCategoriumConfiguration : IEntityTypeConfiguration<TblPosCategorium>
    {
        public void Configure(EntityTypeBuilder<TblPosCategorium> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK__TBL_POS___52965583D79FC41A");

            builder.ToTable("TBL_POS_CATEGORIA");

            builder.Property(e => e.Id).HasColumnName("PK_TBL_POS_CATEGORIA");
            builder.Property(e => e.Descripcion).HasColumnName("DESCRIPCION");
            builder.Property(e => e.Estado).HasColumnName("ESTADO");
            builder.Property(e => e.FechaActualizacionAuditoria).HasColumnName("FECHA_ACTUALIZACION_AUDITORIA");
            builder.Property(e => e.FechaCreacionAuditoria).HasColumnName("FECHA_CREACION_AUDITORIA");
            builder.Property(e => e.FechaEliminacionAuditoria).HasColumnName("FECHA_ELIMINACION_AUDITORIA");
            builder.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("NOMBRE");
            builder.Property(e => e.UsuarioActualizacionAuditoria).HasColumnName("USUARIO_ACTUALIZACION_AUDITORIA");
            builder.Property(e => e.UsuarioCreacionAuditoria).HasColumnName("USUARIO_CREACION_AUDITORIA");
            builder.Property(e => e.UsuarioEliminacionAuditoria).HasColumnName("USUARIO_ELIMINACION_AUDITORIA");
        }
    }
}
