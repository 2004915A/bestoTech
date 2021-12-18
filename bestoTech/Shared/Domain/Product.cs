using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bestoTech.Shared.Domain
{
    public class Product
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public float AvgRating { get; set; } 
        public int TotalReviews { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Category Category { get; set; } 
        public virtual List<ProductCategory> ProductCategory { get; set; }
    }
}
