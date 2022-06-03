using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZombieParty.Models
{
    public class ZombieType
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Type Name")]
        [Required(ErrorMessage = "Type Name have to be fill.")]
        public string TypeName { get; set; }
        [Range(2,5)]
        public int Point { get; set; }
    }
}
