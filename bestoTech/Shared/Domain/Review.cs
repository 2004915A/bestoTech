using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bestoTech.Shared.Domain
{
    public class Review
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a title"), MaxLength(20), MinLength(3)]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter a description"), MaxLength(500), MinLength(10)]
        public string Description { get; set; }
        [Required]
        public int? Rating { get; set; }
        public string Status { get; set; }
        //[Required]
        public int? RecieptId { get; set; }
        //[ForeignKey("UserId")]
        //public int UserId { get; set; }
        //public virtual User User { get; set; }
        [Required(ErrorMessage ="Please select a Product")]
        [ForeignKey("ProductId")]
        public int? ProductId { get; set; }
        public virtual Product Product { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

       
        
        
    }
}
