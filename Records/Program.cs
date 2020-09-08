using System;

namespace Records
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person("Isaac", "Borges");
            var person2 = new Person("Isaac", "Borges");
            if (person1.Equals(person2))
                Console.WriteLine("Person equals");
            else
                Console.WriteLine("Person not equals");

            var personStruct1 = new PersonStruct("Isaac", "Borges");
            var personStruct2 = new PersonStruct("Isaac", "Borges");
            if (personStruct1.Equals(personStruct2))
                Console.WriteLine("PersonStruct equals");
            else
                Console.WriteLine("PersonStruct not equals");

            var personData1 = new PersonRecord("Isaac", "Borges");
            var personData2 = new PersonRecord("Isaac", "Borges");

            if (personData1.Equals(personData2))
                Console.WriteLine("PersonData equals");
            else
                Console.WriteLine("PersonData not equals");

            Console.ReadLine();
        }
    }

    public class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

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

    public struct PersonStruct
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public PersonStruct(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }

    public record PersonRecord
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public PersonRecord(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
