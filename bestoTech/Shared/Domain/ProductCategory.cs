using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bestoTech.Shared.Domain
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public virtual Product Product { get; set; }
        public virtual Category Category { get; set; }
    }
}
