using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SellTech.Domain.Entities;

namespace SellTech.Infrastructure.Persistences.Contexts.Configurations
{
    public class TblPosClienteConfiguration : IEntityTypeConfiguration<TblPosCliente>
    {
        public void Configure(EntityTypeBuilder<TblPosCliente> builder)
        {
            builder.HasKey(e => e.PkTblPosCliente).HasName("PK__TBL_POS___F2F5F85C6B2100CF");

            builder.ToTable("TBL_POS_CLIENTE");

            builder.Property(e => e.PkTblPosCliente).HasColumnName("PK_TBL_POS_CLIENTE");
            builder.Property(e => e.Correo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CORREO");
            builder.Property(e => e.Direccion)
                .IsUnicode(false)
                .HasColumnName("DIRECCION");
            builder.Property(e => e.Estado).HasColumnName("ESTADO");
            builder.Property(e => e.FechaActualizacionAuditoria).HasColumnName("FECHA_ACTUALIZACION_AUDITORIA");
            builder.Property(e => e.FechaCreacionAuditoria).HasColumnName("FECHA_CREACION_AUDITORIA");
            builder.Property(e => e.FechaEliminacionAuditoria).HasColumnName("FECHA_ELIMINACION_AUDITORIA");
            builder.Property(e => e.FkIdTipoDocumento).HasColumnName("FK_ID_TIPO_DOCUMENTO");
            builder.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            builder.Property(e => e.NumeroDocumento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NUMERO_DOCUMENTO");
            builder.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TELEFONO");
            builder.Property(e => e.UsuarioActualizacionAuditoria).HasColumnName("USUARIO_ACTUALIZACION_AUDITORIA");
            builder.Property(e => e.UsuarioCreacionAuditoria).HasColumnName("USUARIO_CREACION_AUDITORIA");
            builder.Property(e => e.UsuarioEliminacionAuditoria).HasColumnName("USUARIO_ELIMINACION_AUDITORIA");

            builder.HasOne(d => d.FkIdTipoDocumentoNavigation).WithMany(p => p.TblPosClientes)
                .HasForeignKey(d => d.FkIdTipoDocumento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TBL_POS_TIPO_DOCUMENTO_2");
        }
    }
}
