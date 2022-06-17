using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ZombieParty_Models
{
  public class Hunter
  {
    [Key]
    public int Id { get; set; }
    [StringLength(10, MinimumLength = 5, ErrorMessage = "MinMaxCaractersValidation")]
        [Display(Name = "Nickname")]
        public string Nickname { get; set; }
        [Display(Name = "Biographie")]
        public string Biography { get; set; }

    // Propriété de navigation vers HuntingLog
    //OBLIGATOIRE Pour la relation 1 à plusieurs avec zombieHuntingLog
    public ICollection<HuntingLog> HuntingLogs { get; set; }
  }
}
