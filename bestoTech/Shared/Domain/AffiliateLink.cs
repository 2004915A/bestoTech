using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bestoTech.Shared.Domain
{
    public class AffiliateLink 
    {
        public int Id { get; set; }
        public string Link { get; set; }
        public int Price { get; set; }
        public virtual Product Product { get; set; }
        public virtual AStore AStore { get; set; }

    }
}
