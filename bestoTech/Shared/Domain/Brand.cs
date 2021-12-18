using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bestoTech.Shared.Domain
{
    public class Brand : BaseDomainModel
    {
        public string Name { get; set; }
        public int AvgRating { get; set; }
        public int NumOfProduct { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public virtual Category Category { get; set; }

    }
}
