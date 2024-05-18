using ExercicePokemon.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExercicePokemon.Controllers
{
    public class PokemonController : Controller
    {
        public IActionResult Index()
        {
            var baseDeDonnees = new FausseBaseDeDonnees();
            var donnees = baseDeDonnees.ObtenirListePokemons();
            return View(donnees);
        }

        public IActionResult Consulter (int id)
        {
            var badedeDonnees = new FausseBaseDeDonnees();
            var donnees = badedeDonnees.ObtenirListePokemons();
            foreach(var e in donnees)
            {
                if(e.Id == id)
                {
                    return View(e);
                }
               
            }
            return NotFound();
        }
    }
}
