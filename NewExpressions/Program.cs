using System;
using System.Collections.Generic;
using System.Text.Json;

namespace NewExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person("Isaac", "Borges");
            var person2 = new Person("Jose", "Pereira");
            var persons = new List<Person> { person1, person2 };
            foreach (var person in persons)
                Console.WriteLine(JsonSerializer.Serialize(person));

            Console.WriteLine();

            Person person11 = new ("Maria", "Silva");
            Person person22 = new ("Marcia", "Costa");
            List<Person> personsS = new() { person11, person22 };
            foreach (var person in personsS)
                Console.WriteLine(JsonSerializer.Serialize(person));
        }
    }

    public record Person
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
