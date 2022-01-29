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
    public class RecipeController : Controller
    {
        private readonly RecipeContext _contexto;

        public RecipeController(RecipeContext contexto)
        {
            _contexto = contexto;
        }

        [HttpGet]

        public IActionResult Get()
        {
            var recipes = _contexto.Recipes.ToList();
            return Ok(recipes);
        }

        // método para obter todas as receitas
        //public async Task<ActionResult<IEnumerable<Recipe>>> GetRecipes()
        //{
        //    return await _contexto.Recipes.ToListAsync();
        //}

        //// método para obter a receita pelo ID
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Recipe>> GetRecipesById(int id)
        //{
        //    Recipe receita = await _contexto.Recipes.FindAsync(id);

        //    if (receita == null)
        //    {
        //        return NotFound();
        //    }

        //    return receita;
        //}

        // método para inserir a receita na base de dados
        //[HttpPost]
        //public async Task<ActionResult<Recipe>> AddRecipes(Recipe receita)
        //{
        //    _contexto.Recipes.Add(receita);
        //    await _contexto.SaveChangesAsync();

        //    return CreatedAtAction("GetRecipesById", new { id = receita.Id }, receita);
        //}

        // método para atualizar a receita na base de dados
        //[HttpPut]
        //public async Task<IActionResult> UpdateRecipe(Recipe receita)
        //{
        //    _contexto.Recipes.Update(receita);
        //    await _contexto.SaveChangesAsync();
        //    return Ok();
        //}

        // método para eliminar a receita na base de dados      
        // temos que associar o id na data annotation visto que
        // para eliminarmos uma receita específica teremos que
        // a encontrar pelo id 
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<Recipe>> DeleteRecipeById(int id)
        //{
        //    var receita = await _contexto.Recipes.FindAsync(id);

        //    if (receita == null)
        //    {
        //        return NotFound();
        //    }

        //    _contexto.Recipes.Remove(receita);
        //    await _contexto.SaveChangesAsync();

        //    return receita;
        //}

        // Métodos JSON para testar a base de dados local        

    //    [HttpGet("JSON")]
    //    public JsonResult ObterReceitasJson()
    //    {
    //        return new JsonResult(BaseDadosReceitas.Current.Receitas);
    //    }

    //    [HttpGet("JSON/{id}")]
    //    public JsonResult ObterReceitasJsonPorId(int id)
    //    {
    //        return new JsonResult(BaseDadosReceitas.Current.Receitas.Find(r => r.ReceitaId == id));
    //    }
    //}


    //public ActionResult Get()
    //    {
    //        try
    //        {
    //            return Ok();
    //        }
    //        catch (Exception ex)
    //        {

    //            return BadRequest($"Erro:{ex}");
    //        }
            
    //    }

    //    // GET api/<RecipeController>
    //    [HttpGet("{id}")]
    //    public string Get(int id)
    //    {
    //        return "value";
    //    }

        //// POST api/<RecipeController>
        //[HttpPost]
        //public ActionResult Post()
        //{
        //    return Ok("ok");
        //}

        //// PUT api/<RecipeController>/
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<RecipeController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
