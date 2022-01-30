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
    public class StepsController : Controller
    {
        private readonly RecipeContext _contexto;

        public StepsController(RecipeContext contexto)
        {
            _contexto = contexto;
        }

        [HttpGet]

        public IActionResult Get()
        {
            var steps = _contexto.Steps.ToList();
            return Ok(steps);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Step>> GetStepById(int id)
        {
            Step step = await _contexto.Steps.FindAsync(id);

            if (step == null)
            {
                return NotFound();
            }

            return step;
        }

    }
}
