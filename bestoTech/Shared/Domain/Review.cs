using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bestoTech.Shared.Domain
{
    public class Review
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public string Status { get; set; }
        public int RecieptId { get; set; }

        public virtual User User { get; set; }
        public virtual Product Product { get; set; }
        public virtual Brand Brand { get; set; }
    }
}
