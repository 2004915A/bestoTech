using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace bestoTech.Shared.Domain
{
    public class ALink 
    {
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Url)]
        public string Link { get; set; }
        [DataType(DataType.Currency)]
        public int? Price { get; set; }
        [Required(ErrorMessage = "Please select a Product")]
        [ForeignKey("ProductId")]
        public int? ProductId { get; set; }
        public virtual Product Product { get; set; }
        [ForeignKey("AStoreId")]
        public int? AStoreId { get; set; }
        public virtual AStore AStore { get; set; }

    }
}
