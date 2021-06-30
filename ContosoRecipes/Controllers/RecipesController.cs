using System.Linq;
using ContosoRecipes.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContosoRecipes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : Controller
    {
        [HttpGet]
        public ActionResult GetRecipes([FromQuery] int count)
        {
            Recipe[] recipes =
            {
                new() {Title = "Oxtail"},
                new() {Title = "Curry Chicken"},
                new() {Title = "Dumplings"}
            };

            if (!recipes.Any())
                return NotFound();
            return Ok(recipes.Take(count));
        }

        [HttpPost]
        public ActionResult CreateNewRecipe([FromBody] Recipe newRecipe)
        {
            return Created("", newRecipe);
        }

        [HttpDelete("{recipeId}")]
        public string DeleteRecipe(string recipeId)
        {
            return recipeId;
        }
    }
}