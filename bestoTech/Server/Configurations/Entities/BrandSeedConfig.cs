using bestoTech.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bestoTech.Server.Configurations.Entities
{
    public class BrandSeedConfig : IEntityTypeConfiguration<Brand>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Brand> builder)
        {
            builder.HasData(

                new Brand
                {
                    Id = 1,
                    BrandId = 1,
                    BrandName = "Sony",
                    NumOfProduct = 1, 
                    CategoryId = 1, 
                    CategoryName = "",
                    ProductName = "", 
                    AvgRating = 0,


                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                 new Brand
                 {
                     Id = 2,
                     BrandId = 2,
                     BrandName = "Apple",
                     NumOfProduct = 2,
                     CategoryId = 2,
                     CatergoryName = " ",
                     ProductName = "",
                     AvgRating = 0,

                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
                 new Brand
                 {
                     Id = 3,
                     BrandId = 3,
                     BrandName = "Samsung",
                     NumOfProduct = 3,
                     CategoryId = 3,
                     CategoryName = " ",
                     ProductName = "",
                     AvgRating = 0,
        

                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 }
            ); ; ;
        }
        }
    }

