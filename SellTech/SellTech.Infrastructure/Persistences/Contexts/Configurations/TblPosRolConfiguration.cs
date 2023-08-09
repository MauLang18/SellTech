using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SellTech.Domain.Entities;

namespace SellTech.Infrastructure.Persistences.Contexts.Configurations
{
    public class TblPosRolConfiguration : IEntityTypeConfiguration<TblPosRol>
    {
        public void Configure(EntityTypeBuilder<TblPosRol> builder)
        {
            builder.HasKey(e => e.PkTblPosRol).HasName("PK__TBL_POS___C1CBCE6F1F8F7805");

            builder.ToTable("TBL_POS_ROL");

            builder.Property(e => e.PkTblPosRol).HasColumnName("PK_TBL_POS_ROL");
            builder.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            builder.Property(e => e.Estado).HasColumnName("ESTADO");
        }
    }
}
