using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SellTech.Domain.Entities;

namespace SellTech.Infrastructure.Persistences.Contexts.Configurations
{
    public class TblPosDepartamentoConfiguration : IEntityTypeConfiguration<TblPosDepartamento>
    {
        public void Configure(EntityTypeBuilder<TblPosDepartamento> builder)
        {
            builder.HasKey(e => e.PkTblPosDepartamento).HasName("PK__TBL_POS___F0A57DC7826C3264");

            builder.ToTable("TBL_POS_DEPARTAMENTO");

            builder.Property(e => e.PkTblPosDepartamento).HasColumnName("PK_TBL_POS_DEPARTAMENTO");
            builder.Property(e => e.Estado).HasColumnName("ESTADO");
            builder.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
        }
    }
}
