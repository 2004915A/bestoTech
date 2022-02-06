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
        public string Title { get; set; }
        public string Description { get; set; }
        public int? Rating { get; set; }
        public string Status { get; set; }
        public int? RecieptId { get; set; }
        //[ForeignKey("UserId")]
        //public int UserId { get; set; }
        //public virtual User User { get; set; }
        [ForeignKey("ProductId")]
        public int? ProductId { get; set; }
        public virtual Product Product { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

       
        
        
    }
}
