using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SellTech.Domain.Entities;

namespace SellTech.Infrastructure.Persistences.Contexts.Configurations
{
    public class TblPosMenuRolConfiguration : IEntityTypeConfiguration<TblPosMenuRol>
    {
        public void Configure(EntityTypeBuilder<TblPosMenuRol> builder)
        {
            builder.HasKey(e => e.PkTblPosMenuRol).HasName("PK__TBL_POS___E9F51C21F55F6B08");

            builder.ToTable("TBL_POS_MENU_ROL");

            builder.Property(e => e.PkTblPosMenuRol).HasColumnName("PK_TBL_POS_MENU_ROL");
            builder.Property(e => e.Estado).HasColumnName("ESTADO");
            builder.Property(e => e.FkIdMenu).HasColumnName("FK_ID_MENU");
            builder.Property(e => e.FkIdRol).HasColumnName("FK_ID_ROL");

            builder.HasOne(d => d.FkIdMenuNavigation).WithMany(p => p.TblPosMenuRols)
                .HasForeignKey(d => d.FkIdMenu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TBL_POS_MENU");

            builder.HasOne(d => d.FkIdRolNavigation).WithMany(p => p.TblPosMenuRols)
                .HasForeignKey(d => d.FkIdRol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TBL_POS_ROL_2");
        }
    }
}
