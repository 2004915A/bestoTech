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
        public string Description { get; set; }
        public float AvgRating { get; set; } 
        public int TotalReviews { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public virtual Brand Brand { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public virtual Category Category { get; set; } 
    }
}
