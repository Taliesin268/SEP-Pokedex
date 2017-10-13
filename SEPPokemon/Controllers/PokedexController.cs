using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SEPPokemon.Controllers
{
    public class PokedexController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult info()
        {
            return View();
        }

        public IActionResult Pokedex()
        {
            return View();
        }
    }
}