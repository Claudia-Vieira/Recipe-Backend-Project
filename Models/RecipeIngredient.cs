using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Backend.Models
{
    public class RecipeIngredient
    {
        public Recipe Recipes { get; set; }
        public int RecipeId { get; set; }
        public Ingredient Ingredients { get; set; }
        public int IngredientId { get; set; }
    }
}
