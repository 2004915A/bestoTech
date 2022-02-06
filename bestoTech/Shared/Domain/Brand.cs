using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bestoTech.Shared.Domain
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float AvgRating { get; set; }
        public int NumOfProduct { get; set; }
        public virtual List<Product> Products { get; set; }
        [ForeignKey("BrandCategoryId")]
        public int? BrandCategoryId { get; set; }
        public virtual BrandCategory BrandCategory { get; set; }

    }
}
