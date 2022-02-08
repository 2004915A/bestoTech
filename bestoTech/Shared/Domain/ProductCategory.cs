using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bestoTech.Shared.Domain
{
    public class ProductCategory
    {
        public int Id { get; set; }
        //[ForeignKey("Product")]
        //public int? ProductId { get; set; }
        //public virtual Product Product { get; set; }
        public virtual List<Category> Categories { get; set; }
    }
}
