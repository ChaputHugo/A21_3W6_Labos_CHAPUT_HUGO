using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZombieParty.Models;

namespace ZombieParty.Controllers
{
    public class ZombieTypeController : Controller
    {
        public IActionResult Index()
        {
            this.ViewBag.MaListe = new List<ZombieType>()
          {
            new ZombieType(){TypeName= "Virus", Id=1},
            new ZombieType(){TypeName= "Contact", Id=2}
          };

            return View();
        }


        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( [Bind("TypeName")] ZombieType zombieType)
        {
            return View();
        }

    }
}
