using System;

namespace RecordsSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Isaac", "Borges");
            Console.WriteLine($"Person: {person.FirstName} {person.LastName}");

            Console.ReadLine();
        }
    }

    public record Person(string FirstName, string LastName);
}
