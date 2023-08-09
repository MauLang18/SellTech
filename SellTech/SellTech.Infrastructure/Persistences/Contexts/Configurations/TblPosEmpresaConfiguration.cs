using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SellTech.Domain.Entities;

namespace SellTech.Infrastructure.Persistences.Contexts.Configurations
{
    public class TblPosEmpresaConfiguration : IEntityTypeConfiguration<TblPosEmpresa>
    {
        public void Configure(EntityTypeBuilder<TblPosEmpresa> builder)
        {
            builder.HasKey(e => e.PkTblPosEmpresa).HasName("PK__TBL_POS___3FCEBF53244963E5");

            builder.ToTable("TBL_POS_EMPRESA");

            builder.Property(e => e.PkTblPosEmpresa).HasColumnName("PK_TBL_POS_EMPRESA");
            builder.Property(e => e.CedulaJuridica)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CEDULA_JURIDICA");
            builder.Property(e => e.Codigo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CODIGO");
            builder.Property(e => e.Correo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CORREO");
            builder.Property(e => e.Direccion)
                .IsUnicode(false)
                .HasColumnName("DIRECCION");
            builder.Property(e => e.Estado).HasColumnName("ESTADO");
            builder.Property(e => e.FechaDeCreacion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DE_CREACION");
            builder.Property(e => e.FkIdDistricto).HasColumnName("FK_ID_DISTRICTO");
            builder.Property(e => e.Logo)
                .IsUnicode(false)
                .HasColumnName("LOGO");
            builder.Property(e => e.Mision)
                .IsUnicode(false)
                .HasColumnName("MISION");
            builder.Property(e => e.NombreEmpresa)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_EMPRESA");
            builder.Property(e => e.Telefono)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TELEFONO");
            builder.Property(e => e.Vision)
                .IsUnicode(false)
                .HasColumnName("VISION");

            builder.HasOne(d => d.FkIdDistrictoNavigation).WithMany(p => p.TblPosEmpresas)
                .HasForeignKey(d => d.FkIdDistricto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TBL_POS_DISTRICTO");
        }
    }
}
