using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SellTech.Domain.Entities;

namespace SellTech.Infrastructure.Persistences.Contexts.Configurations
{
    public class TblPosTipoDocumentoConfiguration : IEntityTypeConfiguration<TblPosTipoDocumento>
    {
        public void Configure(EntityTypeBuilder<TblPosTipoDocumento> builder)
        {
            builder.HasKey(e => e.PkTblPosTipoDocumento).HasName("PK__TBL_POS___AAEEB77371ED31A0");

            builder.ToTable("TBL_POS_TIPO_DOCUMENTO");

            builder.Property(e => e.PkTblPosTipoDocumento).HasColumnName("PK_TBL_POS_TIPO_DOCUMENTO");
            builder.Property(e => e.Abreviacion)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ABREVIACION");
            builder.Property(e => e.Codigo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CODIGO");
            builder.Property(e => e.Estado).HasColumnName("ESTADO");
            builder.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
        }
    }
}
