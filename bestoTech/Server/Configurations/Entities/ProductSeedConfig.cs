using bestoTech.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bestoTech.Server.Configurations.Entities
{
    public class ProductSeedConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(

                 new Product
                 {
                     Id = 1,
                     BrandId = 1, // Apple
                     CategoryId = 1, // Phones
                     Name = "iPhone 13", 
                     Description = "Apple iPhone 13",
                     AvgRating = 0,
                     TotalReviews = 0,

                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
                 new Product
                 {
                     Id = 2,
                     BrandId = 1, // Apple
                     CategoryId = 1, // Phones
                     Name = "iPhone 12",
                     Description = "Apple iPhone 12",
                     AvgRating = 0,
                     TotalReviews = 0,

                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
                 new Product
                 {
                     Id = 3,
                     BrandId = 1, // Apple
                     CategoryId = 1, // Phones
                     Name = "iPhone 11",
                     Description = "Apple iPhone 11",
                     AvgRating = 0,
                     TotalReviews = 0,

                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 }
            );; ;
        }
    }
}
