using bestoTech.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bestoTech.Server.Configurations.Entities
{
    public class ALinkSeedConfig : IEntityTypeConfiguration<ALink>
    {
        public void Configure(EntityTypeBuilder<ALink> builder)
        {
            builder.HasData(

                new ALink
                {
                    Id = 1,
                    Link = "https://www.amazon.sg/",
                    Price = 0,

                },
                new ALink
                {
                    Id = 2,
                    Link = "https://shopee.sg/",
                    Price = 0,
                },
                new ALink
                {
                    Id = 3,
                    Link = "https://www.lazada.sg/",
                    Price = 0,
                }
                ); ; ;
        }
    }
}
