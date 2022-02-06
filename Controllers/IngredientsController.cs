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
    public class IngredientsController : Controller
    {
        private readonly RecipeContext _contexto;

        public IngredientsController(RecipeContext contexto)
        {
            _contexto = contexto;
        }

        [HttpGet]

        public IActionResult Get()
        {
            var ingredients = _contexto.Ingredients.ToList();
            return Ok(ingredients);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Ingredient>> GetIngredientById(int id)
        {
            Ingredient ingredient = await _contexto.Ingredients.FindAsync(id);

            if (ingredient == null)
            {
                return NotFound();
            }

            return ingredient;
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<Ingredient>> DeleteIngredientById(int id)
        {

            var ingredientToDelete = await _contexto.Ingredients.Where(x => x.Id == id).FirstOrDefaultAsync();

            _contexto.Ingredients.Remove(ingredientToDelete);

            await _contexto.SaveChangesAsync();

            return null;

        }

        [HttpPost]
        public async Task<ActionResult<Ingredient>> AddIngredient(Ingredient ingredient, int id)
        {


            try
            {
                _contexto.Ingredients.Add(ingredient);

                await _contexto.SaveChangesAsync();


                return CreatedAtAction("GetIngredientById", new { id = ingredient.Id }, ingredient);

            }
            catch (Exception)
            {

                return BadRequest();

            }



        }

    }
}
