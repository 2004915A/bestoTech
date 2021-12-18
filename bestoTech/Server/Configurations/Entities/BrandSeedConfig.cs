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
                    Name = "Apple",
                    NumOfProduct = 3, 
                    CategoryId = 1, 
                    AvgRating = 0,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                 new Brand
                 {
                     Id = 2,
                     Name = "Samsung",
                     NumOfProduct = 2,
                     CategoryId = 2,
                     AvgRating = 0,

                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
                 new Brand
                 {
                     Id = 3,
                     Name = "Sony",
                     NumOfProduct = 1,
                     CategoryId = 3,
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

