using System;

namespace Coding.Exercise
{
    public class Dog
    {
        // TODO
        string Name;
        string Breed;
        int Weight;

        public Dog(string name, string breed, int weight)
        {
            Name = name;    
            Breed = breed;
            Weight = weight;
        }

        public Dog(string name, int weight, string breed = "mixed-breed")
        {
            Name = name;
            Weight = weight;
            Breed = breed;
        }

        public string Describe(int weight)
        {
            var weightDescription = "";

            if (weight < 5) { weightDescription = "tiny"; }
            else if ( (5 < weight) && (weight < 30) ) { weightDescription = "medium";  }
            else { weightDescription = "large"; }

            return "This dog is named " + Name + ", it's a " + Breed + " , and it weighs " + weight + ", so it's a " + weightDescription + "dog.";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog("Lucky", 25, "german shepherd");
            dog.Describe(25);
        }
    }
}

