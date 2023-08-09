using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SellTech.Domain.Entities;

namespace SellTech.Infrastructure.Persistences.Contexts.Configurations
{
    public class TblPosMenuConfiguration : IEntityTypeConfiguration<TblPosMenu>
    {
        public void Configure(EntityTypeBuilder<TblPosMenu> builder)
        {
            builder.HasKey(e => e.PkTblPosMenu).HasName("PK__TBL_POS___C5BC53E9ADB3B4FC");

            builder.ToTable("TBL_POS_MENU");

            builder.Property(e => e.PkTblPosMenu).HasColumnName("PK_TBL_POS_MENU");
            builder.Property(e => e.Estado).HasColumnName("ESTADO");
            builder.Property(e => e.Icono)
                .IsUnicode(false)
                .HasColumnName("ICONO");
            builder.Property(e => e.IdPadre).HasColumnName("ID_PADRE");
            builder.Property(e => e.Nombre)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            builder.Property(e => e.Urls)
                .IsUnicode(false)
                .HasColumnName("URLS");
        }
    }
}
