using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bestoTech.Shared.Domain
{
    public class Review : BaseDomainModel
    {
        public int ReviewId { get; set; }
        public int ProductId  { get; set; }
        public string ReviewTitle { get; set; }
        public string ReviewDescription { get; set; }
        public int ReviewRating { get; set; }
        public string ReviewStatus { get; set; }
        public int RecieptId { get; set; }
    }
}
