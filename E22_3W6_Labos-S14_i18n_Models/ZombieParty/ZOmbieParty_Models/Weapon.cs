using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZombieParty_Models
{
  public class Weapon
  {
    public int Id { get; set; }
        [Display(Name = "Type name")]
        [StringLength(20, ErrorMessage = "MinCaractersValidation")]
    public string TypeName { get; set; }
        [Display(Name = "Description")]
        [StringLength(50, ErrorMessage = "MinCaractersValidation")]
    public string Description { get; set; }

  }
}
