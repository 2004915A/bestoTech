using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bestoTech.Shared.Domain
{
    public class Product 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float AvgRating { get; set; } 
        public int TotalReviews { get; set; }
        public int? BrandId { get; set; }
        public virtual Brand Brand { get; set; }
        public int? ProductCategoryId { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
    }
}
