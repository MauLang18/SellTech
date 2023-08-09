using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SellTech.Domain.Entities;

namespace SellTech.Infrastructure.Persistences.Contexts.Configurations
{
    public class TblPosRolUsuarioConfiguration : IEntityTypeConfiguration<TblPosRolUsuario>
    {
        public void Configure(EntityTypeBuilder<TblPosRolUsuario> builder)
        {
            builder.HasKey(e => e.PkTblPosRolUsuario).HasName("PK__TBL_POS___E74139245C224DBA");

            builder.ToTable("TBL_POS_ROL_USUARIO");

            builder.Property(e => e.PkTblPosRolUsuario).HasColumnName("PK_TBL_POS_ROL_USUARIO");
            builder.Property(e => e.Estado).HasColumnName("ESTADO");
            builder.Property(e => e.FkIdRol).HasColumnName("FK_ID_ROL");
            builder.Property(e => e.FkIdSucursal).HasColumnName("FK_ID_SUCURSAL");
            builder.Property(e => e.FkIdUsuario).HasColumnName("FK_ID_USUARIO");

            builder.HasOne(d => d.FkIdRolNavigation).WithMany(p => p.TblPosRolUsuarios)
                .HasForeignKey(d => d.FkIdRol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TBL_POS_ROL");

            builder.HasOne(d => d.FkIdSucursalNavigation).WithMany(p => p.TblPosRolUsuarios)
                .HasForeignKey(d => d.FkIdSucursal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TBL_POS_SUCURSAL");

            builder.HasOne(d => d.FkIdUsuarioNavigation).WithMany(p => p.TblPosRolUsuarios)
                .HasForeignKey(d => d.FkIdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TBL_POS_USUARIO");
        }
    }
}
