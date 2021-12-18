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
                     BrandId = 1,
                     BrandName = "Sony",
                     CategoryId = 3,
                     CategoryName = "C",
                     ProductName = "Alpha 7 IV full-frame hybrid camera",
                     Description = "The latest sensor, processing engine, and AI-based autofocus work in tandem with cutting-edge still-photography and moviemaking technology to create a fresh, dynamic imaging experience. The α7 IV is the ideal hybrid, providing breathtaking still and movie imagery, along with flexible connectivity for on-the-spot transmission of your images.",
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
                     BrandId = 2,
                     CategoryId = 2,
                     CategoryName = "",
                     ProductName = "Alpha 7 IV full-frame hybrid camera",
                     Description = "The latest sensor, processing engine, and AI-based autofocus work in tandem with cutting-edge still-photography and moviemaking technology to create a fresh, dynamic imaging experience. The α7 IV is the ideal hybrid, providing breathtaking still and movie imagery, along with flexible connectivity for on-the-spot transmission of your images.",
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
                     BrandId = 3,
                     BrandName = "",
                     CategoryId = 1,
                     CategoryName = "",
                     ProductName = "Alpha 7 IV full-frame hybrid camera",
                     Description = "The latest sensor, processing engine, and AI-based autofocus work in tandem with cutting-edge still-photography and moviemaking technology to create a fresh, dynamic imaging experience. The α7 IV is the ideal hybrid, providing breathtaking still and movie imagery, along with flexible connectivity for on-the-spot transmission of your images.",
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
