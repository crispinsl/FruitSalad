using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FruitSaladLibrary;

namespace FruitSaladDeliveryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Strawberry sweetStrawberry = new Strawberry("Bright Red", 15.0, true, true, 9);
            Strawberry sourStrawberry = new Strawberry("Light Red", 10.0, false, false, 4);
            //creating a Fruit sald
            var salad = new FruitSalad(new List<Fruit> { sweetStrawberry, sourStrawberry }, 3);
            //testing ToString
            Console.WriteLine(salad.ToString());
            salad.Add(new Strawberry("Dark Red", 20.0, true, true, 10));
            Console.WriteLine(salad.ToString());
            //test serving
            Console.WriteLine(salad.Serve());
            Console.WriteLine(salad.Serve());
            Console.WriteLine(salad.Serve());
            Console.WriteLine(salad.Serve()); //should exceed servings
            Console.WriteLine(salad.ToString());
        }
    }
}
