using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SellTech.Domain.Entities;

namespace SellTech.Infrastructure.Persistences.Contexts.Configurations
{
    public class TblPosSucursalConfiguration : IEntityTypeConfiguration<TblPosSucursal>
    {
        public void Configure(EntityTypeBuilder<TblPosSucursal> builder)
        {
            builder.HasKey(e => e.PkTblPosSucursal).HasName("PK__TBL_POS___5EBA48ED95028F4F");

            builder.ToTable("TBL_POS_SUCURSAL");

            builder.Property(e => e.PkTblPosSucursal).HasColumnName("PK_TBL_POS_SUCURSAL");
            builder.Property(e => e.Codigo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CODIGO");
            builder.Property(e => e.Correo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CORREO");
            builder.Property(e => e.Descripcion)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            builder.Property(e => e.Direccion)
                .IsUnicode(false)
                .HasColumnName("DIRECCION");
            builder.Property(e => e.Estado).HasColumnName("ESTADO");
            builder.Property(e => e.FkIdDistricto).HasColumnName("FK_ID_DISTRICTO");
            builder.Property(e => e.FkIdEmpresa).HasColumnName("FK_ID_EMPRESA");
            builder.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            builder.Property(e => e.Telefono)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TELEFONO");

            builder.HasOne(d => d.FkIdDistrictoNavigation).WithMany(p => p.TblPosSucursals)
                .HasForeignKey(d => d.FkIdDistricto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TBL_POS_DISTRICTO_2");

            builder.HasOne(d => d.FkIdEmpresaNavigation).WithMany(p => p.TblPosSucursals)
                .HasForeignKey(d => d.FkIdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TBL_POS_EMPRESA");
        }
    }
}
