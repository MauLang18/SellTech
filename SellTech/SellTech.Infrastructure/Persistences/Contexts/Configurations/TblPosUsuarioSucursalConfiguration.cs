using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SellTech.Domain.Entities;

namespace SellTech.Infrastructure.Persistences.Contexts.Configurations
{
    public class TblPosUsuarioSucursalConfiguration : IEntityTypeConfiguration<TblPosUsuarioSucursal>
    {
        public void Configure(EntityTypeBuilder<TblPosUsuarioSucursal> builder)
        {
            builder.HasKey(e => e.PkTblPosUsuarioSucursal).HasName("PK__TBL_POS___B01C265177504659");

            builder.ToTable("TBL_POS_USUARIO_SUCURSAL");

            builder.Property(e => e.PkTblPosUsuarioSucursal).HasColumnName("PK_TBL_POS_USUARIO_SUCURSAL");
            builder.Property(e => e.Estado).HasColumnName("ESTADO");
            builder.Property(e => e.FkIdSucursal).HasColumnName("FK_ID_SUCURSAL");
            builder.Property(e => e.FkIdUsuario).HasColumnName("FK_ID_USUARIO");

            builder.HasOne(d => d.FkIdSucursalNavigation).WithMany(p => p.TblPosUsuarioSucursals)
                .HasForeignKey(d => d.FkIdSucursal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TBL_POS_SUCURSAL_10");

            builder.HasOne(d => d.FkIdUsuarioNavigation).WithMany(p => p.TblPosUsuarioSucursals)
                .HasForeignKey(d => d.FkIdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TBL_POS_USUARIO_10");
        }
    }
}
