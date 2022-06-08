using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZombieParty.Models;

namespace ZombieParty.Controllers
{
  public class ZombieController : Controller
  {
    public IActionResult Index()
    {
            this.ViewBag.MaListe = new List<Zombie>()
      {
        new Zombie(){Name= "LeChuck", Point=5, },
        new Zombie(){Name= "Lenore", Point=4, },
        new Zombie(){Name= "Draugr", Point=2, },
        new Zombie(){Name= "Ragamuffin", Point=5, },
        new Zombie(){Name= "Taxidermy", Point=1, },
        new Zombie(){Name= "chien de l'enfer", Point=7, },
        new Zombie(){Name= "Avogadro", Point=9 }
      };


            return View();
    }
  }
}
