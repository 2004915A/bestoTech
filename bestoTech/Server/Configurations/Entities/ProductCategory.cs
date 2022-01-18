using bestoTech.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bestoTech.Server.Configurations.Entities
{
    public class ProductCategorySeedConfig : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ProductCategory> builder)
        {
            builder.HasData(

                new ProductCategory
                {
                    Id = 1,
                },
                new ProductCategory
                {
                    Id = 2,
                },
                new ProductCategory
                {
                    Id = 3,
                });;
        }
    }
}
