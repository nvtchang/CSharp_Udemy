
var ingredients = new List<Ingredient>
{
    new Cheddar(),
    new Mozzarella(),
    new TomatoSauce(),
};

//Because the name is override so It will print the name in derived class
//If remove override, the name of the base class will be used
foreach (var ingredient in ingredients)
{
    Console.WriteLine(ingredient.Name);
}
public class Pizza
{
    private List<Ingredient> _ingredients = new List<Ingredient>();
    public void AddIngredient(Ingredient ingredients) => _ingredients.Add(ingredients);
}

public class Ingredient
{
    public virtual string Name { get; } = "Some ingredient";
    public int PublicField;
    public string PublicMethod() =>
        "This method is PUBLIC in the Ingredient class.";
    private string PrivateMethod() =>
       "This method is PRIVATE in the Ingredient class.";
    protected string ProtectedMethod() =>
        "This method is PROTECTED in the Ingredient class.";
}

public class Cheddar : Cheese
{
    public override string Name => "Cheddar cheese";
    public int AgedMonthed { get; set; }
    public void UseMethodFromBaseClass()
    {
       Console.WriteLine(PublicMethod());
       Console.WriteLine(ProtectedMethod());
       //Console.WriteLine(PrivateMethod());
    }
}

public class Cheese : Ingredient
{

}

public class TomatoSauce : Ingredient
{
    public override string Name => "Tomato sauce";
    public int TomatosIn100Grams { get; set; }
}

public class Mozzarella : Cheese
{
    public override string Name => "Mozzarella";
    public bool IsLight { get; }
}

