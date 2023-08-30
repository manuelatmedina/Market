using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Shared.Entities
{
    public class Country
    {
        public int Id { get; set; }
        [Display(Name = "Pais")]
        [MaxLength(100, ErrorMessage ="El campo {0} debe tener màximo {1} caràcteres")]
        [Required(ErrorMessage ="El campo {0} es obligatorio.")]
        public string Name { get; set; } = null;
    }
}
