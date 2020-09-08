using System;

namespace IsNotOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa = new Person("Isaac", "Borges");
            if (pessoa != null)
            {
                Console.WriteLine("1 opção");
                Console.WriteLine(pessoa.ToString());
                Console.WriteLine();
            }

            if (!(pessoa is null))
            {
                Console.WriteLine("1 opção");
                Console.WriteLine(pessoa.ToString());
                Console.WriteLine();
            }

            if (pessoa is not null)
            {
                Console.WriteLine("3 opção");
                Console.WriteLine(pessoa.ToString());
                Console.WriteLine();
            }

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
}
