using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bestoTech.Shared.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string EmailAddress { get; set; }
        public virtual List<Review> Reviews { get; set; }
    }
}
