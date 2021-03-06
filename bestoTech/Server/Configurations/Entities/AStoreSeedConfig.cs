using bestoTech.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bestoTech.Server.Configurations.Entities
{
    public class AStoreSeedConfig : IEntityTypeConfiguration<AStore>
    {
        public void Configure(EntityTypeBuilder<AStore> builder)
        {
            builder.HasData(

                new AStore
                {
                    Id = 1,
                    Name = "Amazon",
                },
                new AStore
                {
                    Id = 2,
                    Name = "Shopee",
                },
                new AStore
                {
                    Id = 3,
                    Name = "Lazada",
                }
                ); ; ;
        }
    }
}
