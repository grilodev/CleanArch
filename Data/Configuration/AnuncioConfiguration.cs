using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class AnuncioConfiguration : IEntityTypeConfiguration<Anuncio>
    {
        public void Configure(EntityTypeBuilder<Anuncio> builder)
        {
            builder.Property(p => p.Marca).HasMaxLength(45).IsRequired();
            builder.Property(p => p.Modelo).HasMaxLength(45).IsRequired();
            builder.Property(p => p.Versao).HasMaxLength(45).IsRequired();
            builder.Property(p => p.Observacao).IsRequired();
            
            builder.Property(p => p.Ano).IsRequired();
            builder.Property(p => p.Quilometragem).IsRequired();
        }
    }
}
