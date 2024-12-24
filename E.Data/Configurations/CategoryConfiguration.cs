using Et.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Et.Data.Configurations
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Image).HasMaxLength(50);
            builder.HasData(
                new Category
                {
                    Name = "Elektornik",
                    Id = 1,
                    IsActive = true,
                    IsTopMenü = true,
                    ParenId = 0,
                    OrderNo = 1,
                }, new Category
                {
                    Name = "Bilgisayar",
                    Id = 2,
                    IsActive = true,
                    IsTopMenü = true,
                    ParenId = 0,
                    OrderNo = 2,
                }
                );
                
        }
    }
}
