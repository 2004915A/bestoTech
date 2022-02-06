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
                    Description = "Apple Inc. is an American multinational technology company that specializes in consumer electronics, software and online services.",
                    NumOfProduct = 0, 
                    AvgRating = 0
                },
                 new Brand
                 {
                     Id = 2,
                     Name = "Samsung",
                     Description = "Samsung Electronics Co., Ltd. is a South Korean multinational electronics corporation headquartered in the Yeongtong District of Suwon.",
                     NumOfProduct = 0,
                     AvgRating = 0

                 },
                 new Brand
                 {
                     Id = 3,
                     Name = "Sony",
                     Description = "Sony Group Corporation, commonly known as Sony and stylized as SONY, is a Japanese multinational conglomerate corporation headquartered in Kōnan, Minato, Tokyo, Japan.",
                     NumOfProduct = 0,
                     AvgRating = 0
                 }
            ); ; ;
        }
        }
    }

