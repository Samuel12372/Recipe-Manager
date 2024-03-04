using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FoodRecipeManager2
{
    [Serializable]
    public class Recipes
    {
        
        public string Title { get; set; }
        public string Description { get; set; }

        private int _time;
        public int Time
        {
            get { return _time; }
            set
            {
                if (value > 0) 
                {
                    _time = value;
                }
                else
                {
                    throw new ArgumentException("Time cannot be zero or negative.");
                }
            }
        }
        public string Ingredients { get; set; }
        public string Method { get; set; }


        public Recipes(string title, string description, int time, string ingredients, string method)
        {
            Title = title;        
            Description = description;
            Time = time;
            Ingredients = ingredients;
            Method = method;    
        }

        public Recipes(Recipes otherRecipe)
        {
            Title = otherRecipe.Title;
            Description = otherRecipe.Description;
            Time = otherRecipe.Time;
            Ingredients = otherRecipe.Ingredients;
            Method = otherRecipe.Method;
        }

         
    }
}
