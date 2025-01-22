using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitSaladLibrary
{
    //to make a new class, right click the library name, hit add, then class. make sure to end the name in .cs
    public abstract class Fruit
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public double Weight { get; set; }
        // double means the a longer number is returned [ie decimals]
        public bool IsOrganic { get; set; }

        public Fruit(string name, string color, double weight, bool isOrganic)
        {
            Name = name;
            Color = color;
            Weight = weight;
            IsOrganic = isOrganic;
        }
        //abstract method to enforce implementation in derived classes
        public abstract string Describe();
        // this is a manual input method for description? isnt defined. string is the return type. for instance, it could be int Describe();

        public override string ToString()
        {
            //define a two string method to spit out all the info
            //this is a more automatic method, but should later be replaced with something better
            string organicLabel = IsOrganic ? "Organic" : "Non-Organic";
            return $"{Name} ({Color}, {Weight}g, {organicLabel})";
        }
    }
}
