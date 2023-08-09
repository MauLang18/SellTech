using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SellTech.Domain.Entities;

namespace SellTech.Infrastructure.Persistences.Contexts.Configurations
{
    public class TblPosDistrictoConfiguration : IEntityTypeConfiguration<TblPosDistricto>
    {
        public void Configure(EntityTypeBuilder<TblPosDistricto> builder)
        {
            builder.HasKey(e => e.PkTblPosDistricto).HasName("PK__TBL_POS___745B874A89FFA475");

            builder.ToTable("TBL_POS_DISTRICTO");

            builder.Property(e => e.PkTblPosDistricto).HasColumnName("PK_TBL_POS_DISTRICTO");
            builder.Property(e => e.Estado).HasColumnName("ESTADO");
            builder.Property(e => e.FkIdProvincia).HasColumnName("FK_ID_PROVINCIA");
            builder.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");

            builder.HasOne(d => d.FkIdProvinciaNavigation).WithMany(p => p.TblPosDistrictos)
                .HasForeignKey(d => d.FkIdProvincia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TBL_POS_PROVINCIA");
        }
    }
}
