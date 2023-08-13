using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SellTech.Domain.Entities;

namespace SellTech.Infrastructure.Persistences.Contexts.Configurations
{
    public class TblPosUsuarioConfiguration : IEntityTypeConfiguration<TblPosUsuario>
    {
        public void Configure(EntityTypeBuilder<TblPosUsuario> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK__TBL_POS___A0309D793BDA0851");

            builder.ToTable("TBL_POS_USUARIO");

            builder.Property(e => e.Id).HasColumnName("PK_TBL_POS_USUARIO");
            builder.Property(e => e.Correo)
                .IsUnicode(false)
                .HasColumnName("CORREO");
            builder.Property(e => e.Estado).HasColumnName("ESTADO");
            builder.Property(e => e.FechaActualizacionAuditoria).HasColumnName("FECHA_ACTUALIZACION_AUDITORIA");
            builder.Property(e => e.FechaCreacionAuditoria).HasColumnName("FECHA_CREACION_AUDITORIA");
            builder.Property(e => e.FechaEliminacionAuditoria).HasColumnName("FECHA_ELIMINACION_AUDITORIA");
            builder.Property(e => e.Imagen)
                .IsUnicode(false)
                .HasColumnName("IMAGEN");
            builder.Property(e => e.Pass)
                .IsUnicode(false)
                .HasColumnName("PASS");
            builder.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USERNAME");
            builder.Property(e => e.AuthType)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("AUTHTYPE");
            builder.Property(e => e.UsuarioActualizacionAuditoria).HasColumnName("USUARIO_ACTUALIZACION_AUDITORIA");
            builder.Property(e => e.UsuarioCreacionAuditoria).HasColumnName("USUARIO_CREACION_AUDITORIA");
            builder.Property(e => e.UsuarioEliminacionAuditoria).HasColumnName("USUARIO_ELIMINACION_AUDITORIA");
        }
    }
}
