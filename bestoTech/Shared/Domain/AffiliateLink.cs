using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bestoTech.Shared.Domain
{
    public class AffiliateLink : BaseDomainModel
    {
        public string Link { get; set; }
        public int Price { get; set; }
        public int ProductId {get;set;}
        public virtual Product Product { get; set; }
        public int AStoreId { get; set; }
        public virtual AStore AStore { get; set; }

    }
}
