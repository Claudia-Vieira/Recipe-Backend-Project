using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_Backend.Data;
using Project_Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Project_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : Controller
    {
        private readonly RecipeContext _contexto;

        public RecipesController(RecipeContext contexto)
        {
            _contexto = contexto;
        }

        [HttpGet]

        public IActionResult Get()
        {
            var recipes = _contexto.Recipes.ToList();
            return Ok(recipes);
        }

       
        [HttpGet("{id}")]
        public async Task<ActionResult<Recipe>> GetRecipeById(int id)
        {
            Recipe recipe = await _contexto.Recipes.Include(x=>x.Ingredients).Include(x=>x.Steps).Where(x=>x.Id == id).FirstOrDefaultAsync();

            if (recipe == null)
            {
                return NotFound();
            }

            return recipe;
        }

        [HttpPost]
        public async Task<ActionResult<Recipe>> AddRecipe(Recipe recipe)
        {

            _contexto.Recipes.Add(recipe);

            await _contexto.SaveChangesAsync();

            return CreatedAtAction("GetRecipeById", new { id = recipe.Id }, recipe);

            //_contexto.Recipes.Add(recipe);

            //await _contexto.SaveChangesAsync();

            //return CreatedAtAction("GetRecipeById", new { id = recipe.Id }, recipe);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Recipe>> DeleteRecipeById(int id)
        {

            var recipeToDelete = await _contexto.Recipes.Where(x => x.Id == id).Include(x => x.Ingredients).Include(x => x.Steps).Where(x => x.Id == id).FirstOrDefaultAsync();

            _contexto.Recipes.Remove(recipeToDelete);

            await _contexto.SaveChangesAsync();

            return null;

        }

    }
}
