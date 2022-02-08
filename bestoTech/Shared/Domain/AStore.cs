using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace bestoTech.Shared.Domain
{
    public class AStore
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a name"), MaxLength(20)]
        public string Name { get; set; }
    }
}
