using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookieCookbook.Class;

namespace CookieCookbook
{
    //public class Printer
    //{
         
    //}

    //public interface IPrinter
    //{

    //}

    public class PrintAvailableIngredients
    {
        public void PrintAvailable(List<Ingredients> ingredients)
        {
            foreach (Ingredients ingredient in ingredients)
            {
                Console.WriteLine($"{ingredient.Id}. {ingredient.Name}");
            }
        }      
    }

    public class PrintExisting
    {
        public void Print (List<string> recipes)
        {

        }
    }
}
