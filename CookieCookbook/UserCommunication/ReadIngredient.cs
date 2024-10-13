using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookieCookbook.Class;

namespace CookieCookbook.UserCommunication
{
    public class ReadIngredient
    {
        private readonly List<Ingredients> _ingredients;
        public ReadIngredient(List<Ingredients> ingredients)
        {
            _ingredients = ingredients;
        }
        
    }
}
