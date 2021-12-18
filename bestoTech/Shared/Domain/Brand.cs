using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bestoTech.Shared.Domain
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AvgRating { get; set; }
        public int NumOfProduct { get; set; }
        public int ProductId { get; set; }
        public virtual List<Product> Products { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}
