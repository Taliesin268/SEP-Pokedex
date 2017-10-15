using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEPPokemon.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace SEPPokemon.Controllers
{
    public class PokedexController : Controller
    {
        private readonly SEPPokemonContext _context;

        public PokedexController(SEPPokemonContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult info()
        {
            return View();
        }

        public async Task<IActionResult> Pokedex()
        {
            return View(await _context.Pokemon.ToListAsync());
        }
    }
}