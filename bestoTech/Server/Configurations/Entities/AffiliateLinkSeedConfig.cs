using bestoTech.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bestoTech.Server.Configurations.Entities
{
    public class AffiliateLinkSeedConfig : IEntityTypeConfiguration<AffiliateLink>
    {
        public void Configure(EntityTypeBuilder<AffiliateLink> builder)
        {
            builder.HasData(

                new AffiliateLink
                {
                    Id = 1,
                    ProductId = 1,
                    AStoreId = 1,
                    Link = "https://www.amazon.sg/",
                    Price = 0,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new AffiliateLink
                {
                    Id = 2,
                    ProductId = 2,
                    AStoreId = 2,
                    Link = "https://shopee.sg/",
                    Price = 0,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new AffiliateLink
                {
                    Id = 3,
                    ProductId = 3,
                    AStoreId = 3,
                    Link = "https://www.lazada.sg/",
                    Price = 0,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
                ); ; ;
        }
    }
}
