using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SellTech.Domain.Entities;

namespace SellTech.Infrastructure.Persistences.Contexts.Configurations
{
    public class TblPosProvinciumConfiguration : IEntityTypeConfiguration<TblPosProvincium>
    {
        public void Configure(EntityTypeBuilder<TblPosProvincium> builder)
        {
            builder.HasKey(e => e.PkTblPosProvincia).HasName("PK__TBL_POS___1E068A85AD1BA6DE");

            builder.ToTable("TBL_POS_PROVINCIA");

            builder.Property(e => e.PkTblPosProvincia).HasColumnName("PK_TBL_POS_PROVINCIA");
            builder.Property(e => e.Estado).HasColumnName("ESTADO");
            builder.Property(e => e.FkIdDepartamento).HasColumnName("FK_ID_DEPARTAMENTO");
            builder.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");

            builder.HasOne(d => d.FkIdDepartamentoNavigation).WithMany(p => p.TblPosProvincia)
                .HasForeignKey(d => d.FkIdDepartamento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TBL_POS_DEPARTAMENTO");
        }
    }
}
