using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Backend.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public int Duration { get; set; }
        public string Dificulty { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }
        public ICollection<Step> Steps { get; set; }
    }
}
