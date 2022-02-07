using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bestoTech.Shared.Domain
{
    public class Product 
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a Name"), MaxLength(20), MinLength(3)]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please enter a description"), MaxLength(500), MinLength(10)]
        public string Description { get; set; }
        [Required]
        public float AvgRating { get; set; } 
        public int? TotalReviews { get; set; }
        [Required]
        [ForeignKey("Brand")]
        public int? BrandId { get; set; }
        public virtual Brand Brand { get; set; }
        [ForeignKey("ProductCategoryId")]
        public int? ProductCategoryId { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
        public virtual List<Review> Reviews { get; set; }
    }
}
