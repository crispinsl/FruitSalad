using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitSaladLibrary
{
    public class FruitSalad
    {
        public List<Fruit> fruits;
        public int servings;

        // constructor
        public FruitSalad(List<Fruit> ingredients, int numServings)
        {
            fruits = new List<Fruit>(ingredients);
            servings = numServings;
        }
        public override string ToString()
        {
            string fruitDetails = string.Join(", ", fruits);
            return $" {servings} servings of fruit salad with [{fruitDetails}]";
        }
        // add a fruit to the salad
        public void Add(Fruit fruit)
        {
            fruits.Add(fruit);
        }
        public string Serve()
        {
            if (servings > 0)
            {
                servings--;
                return "Enjoy yout fruit salad!";
            }
            else
            {
                return "Sorry, no fruit salad for you.";
            }
        }
    }
}
