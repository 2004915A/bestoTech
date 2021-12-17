using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bestoTech.Shared.Domain
{
    public class Product : BaseDomainModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int AverageRating { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual ProductCategory ProductCategory { get; set; } 
    }
}
