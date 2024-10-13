using CookieCookbook;
using CookieCookbook.DataAccess;
using CookieCookbook.Class;

var stringTextual = new StringTextualRepository();
List<string> recipes = stringTextual.Read(Constants.RecipePath + Constants.FileName);

var printExisting = new PrintExisting(recipes);
var test = new PrintAvailableIngredients();
var converter = new JsonConverter();
List<Ingredients> newList = converter.LoadJson();
test.PrintAvailable(newList);

