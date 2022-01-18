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
                     Name = "iPhone 13", 
                     Description = "Apple iPhone 13",
                     AvgRating = 0,
                     TotalReviews = 0,
                     BrandId = 1
                 },
                 new Product
                 {
                     Id = 2,
                     Name = "iPhone 12",
                     Description = "Apple iPhone 12",
                     AvgRating = 0,
                     TotalReviews = 0,
                 },
                 new Product
                 {
                     Id = 3,
                     Name = "iPhone 11",
                     Description = "Apple iPhone 11",
                     AvgRating = 0,
                     TotalReviews = 0,
                 }
            );;; ;
        }
    }
}
