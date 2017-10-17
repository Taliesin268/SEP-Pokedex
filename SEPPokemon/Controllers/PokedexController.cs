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

        public async Task<IActionResult> info(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            var pokemon = from p in _context.Pokemon
                      select p;

            ViewData["id"] = id;

            pokemon = pokemon.Where(s => (s.PokemonId == id || s.PokemonId == id + 1 || s.PokemonId == id - 1));
            pokemon = pokemon.OrderBy(s => s.PokemonId);

            if (pokemon == null)
            {
                return NotFound();
            }

            return View(await  pokemon.ToListAsync());
        }

        public async Task<IActionResult> Pokedex()
        {
            return View(await _context.Pokemon.ToListAsync());
        }
    }
}