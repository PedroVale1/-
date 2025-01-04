using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductCatalog.Models;

namespace ProductCatalog.Data.Mappings
{
    public class ProductModelMap : IEntityTypeConfiguration<ProductModel>
    {
        public void Configure(EntityTypeBuilder<ProductModel> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.Description)
                .HasMaxLength(500);

            builder.Property(p => p.Price)
                .HasColumnType("decimal(18,2)");

            builder.Property(p => p.AvailableForSale)
                .IsRequired();
        }
    }
}
