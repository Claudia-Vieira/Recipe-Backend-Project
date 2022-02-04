using Project_Backend.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Backend.Repo
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly RecipeContext _context;

        public RecipeRepository(RecipeContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) >0;
        }
    }
}
