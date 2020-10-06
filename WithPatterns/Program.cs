using System;

namespace WithPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person("Isaac", "Borges");
            Console.WriteLine($"Person1: {person1}");

            var person2 = person1 with { FirstName = "João" };
            Console.WriteLine($"Person2: {person2}");

            var person3 = person2 with { LastName = "Silva" };
            Console.WriteLine($"Person3: {person3}");

            var person4 = person1 with { LastName = "Silva" };
            Console.WriteLine($"Person3: {person4}");

            Console.ReadLine();

            //var ps = new PersonClass("Nome", "sobrenome");
            //var ps2 = ps with { LastName = "teste" };
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

    public class PersonClass
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }

        public PersonClass(string firstName, string lastName)
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
