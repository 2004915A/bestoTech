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
        [Required(ErrorMessage = "Please enter a name"), MaxLength(20)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter a description"), MaxLength(500), MinLength(10)]
        public string Description { get; set; }
        public float? AvgRating { get; set; }
        public int? NumOfProduct { get; set; }
        public virtual List<Product> Products { get; set; }
        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}
