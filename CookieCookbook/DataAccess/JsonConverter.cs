using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using CookieCookbook.Class;

namespace CookieCookbook.DataAccess
{
    public class JsonConverter
    {
        public List<Ingredients> LoadJson()
        {
            using (StreamReader r = new StreamReader(Constants.IngredientsPath))
            {
                string json = r.ReadToEnd();
                List<Ingredients> ingredients = JsonConvert.DeserializeObject<List<Ingredients>>(json);
                return ingredients;
            }
        }
    }
}
