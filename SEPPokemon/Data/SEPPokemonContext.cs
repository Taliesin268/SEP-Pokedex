using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SEPPokemon.Models
{
    public class SEPPokemonContext : DbContext
    {
        public SEPPokemonContext (DbContextOptions<SEPPokemonContext> options)
            : base(options)
        {
        }

        public DbSet<SEPPokemon.Models.Pokemon> Pokemon { get; set; }
    }
}
