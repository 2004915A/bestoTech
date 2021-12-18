using bestoTech.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bestoTech.Server.Configurations.Entities
{
    public class ReviewSeedConfig : IEntityTypeConfiguration<Review>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Review> builder)
        {
            builder.HasData(
                
                new Review
                {
                    Id = 1,
                    ProductId = 1,
                    ReviewTitle = "Title1",
                    ReviewDescription = " ",
                    ReviewRating = 1,
                    ReviewStatus = "Yes",
                    RecieptId = 1,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                 new Review
                 {
                     Id = 2,
                     ProductId = 2,
                     ReviewTitle = "Title2",
                     ReviewDescription = " ",
                     ReviewRating = 2,
                     ReviewStatus = "Yes",
                     RecieptId = 2,

                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
                 new Review
                 {
                     Id = 3,
                     ProductId = 3,
                     ReviewTitle = "Title3",
                     ReviewDescription = " ",
                     ReviewRating = 3,
                     ReviewStatus = "Yes",
                     RecieptId = 3,

                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 }
            ); ; ;
        }
        }
    }
