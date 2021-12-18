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
                     ProductName = "Alpha 7 IV full-frame hybrid camera",

                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
                 new Product
                 {
                     Id = 2,
                     ProductName = "Blue",
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 }
);
        }
    }
}
