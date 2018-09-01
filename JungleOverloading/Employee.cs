using System;
using System.Collections.Generic;

namespace JungleOverloading
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public readonly List<string> Restaurants = new List<string>(new[] { "R1", "R2", "R3" });

        public Employee(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public void eat()
        {
            var randomIndex = new Random();
            Console.WriteLine($"{FirstName} {LastName} is eating at {Restaurants[randomIndex.Next(0,Restaurants.Count)]} restaurant");
        }

        public void eat(string food)
        {
            Console.WriteLine($"{FirstName} {LastName} is eating {food} at office");
        }

        public void eat(List<string> companions)
        {
            var randomIndex = new Random();
            var randomRestaurant = Restaurants[randomIndex.Next(0, Restaurants.Count)];
            var output = $"{this.FirstName} {this.LastName} is eating at {randomRestaurant} with ";
            foreach (var companion in companions)
            {
                output += companion + " ";
            }

            Console.WriteLine(output);
        }


        public void eat(string food, List<string> companions)
        {
            var randomIndex = new Random();
            var randomRestaurant = Restaurants[randomIndex.Next(0, Restaurants.Count)];
            var output = $"{this.FirstName} {this.LastName} is eating {food} at {randomRestaurant} with ";
            foreach (var companion in companions)
            {
                output += companion + " ";
            }

            Console.WriteLine(output);
        }
    }
}
