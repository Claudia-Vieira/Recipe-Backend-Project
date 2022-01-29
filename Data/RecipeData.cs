using Project_Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Backend.Data
{
    public class RecipeData
    {
        public static RecipeData Current { get; } = new RecipeData();

            public List<Recipe> Recipes { get; set; }

            public RecipeData()
            {
                Recipes = new List<Recipe>
            {
                 new Recipe
                 {
                     Id = 1,
                     Title = "Baba de Camelo",
                     ImageUrl = "/assets/baba-camelo.jpg",
                     Duration = 30,
                     Dificulty = "Fácil",
                    
                 },
                 new Recipe
                 {
                     Id = 2,
                     Title = "Leite Creme",
                     ImageUrl = "/assets/leite-creme.jpg",
                     Duration = 15,
                     Dificulty = "Fácil",

                 },

                 new Recipe
                 {
                     Id = 3,
                     Title = "Bolo de Chocolate",
                     ImageUrl = "/assets/bolo-chocolate.jpg",
                     Duration = 60,
                     Dificulty = "Fácil",

                 },

                 
             };
            }
        }
    }
