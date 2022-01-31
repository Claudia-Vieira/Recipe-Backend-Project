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
            Recipe receita = await _contexto.Recipes.Include(x=>x.Ingredients).Where(x=>x.Id == id).FirstOrDefaultAsync();

            if (receita == null)
            {
                return NotFound();
            }

            return receita;
        }

    }
}
