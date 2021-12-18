using bestoTech.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bestoTech.Server.Configurations.Entities
{
    public class CategorySeedConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Category> builder)
        {
            builder.HasData(

                new Category
                {
                    Id = 1,
                    Name = "Phones",
                },
                new Category
                {
                    Id = 2,
                    Name = "Audio and Visual",
                },
                new Category
                {
                    Id = 3,
                    Name = "Cameras",
                });
        }
    }
}
