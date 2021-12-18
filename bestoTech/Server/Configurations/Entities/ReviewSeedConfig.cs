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
                    Title = "Title1",
                    Description = " ",
                    Rating = 1,
                    Status = "Yes",
                    RecieptId = 1,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                 new Review
                 {
                     Id = 2,
                     Title = "Title2",
                     Description = " ",
                     Rating = 2,
                     Status = "Yes",
                     RecieptId = 2,

                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
                 new Review
                 {
                     Id = 3,
                     Title = "Title3",
                     Description = " ",
                     Rating = 3,
                     Status = "Yes",
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
