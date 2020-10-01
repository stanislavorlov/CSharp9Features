using System;

namespace CSharp9Demo
{
    public record Person
    {
        public string FirstName { get; }
        public string LastName { get; }
        public DateTime BirthDate { get; init; }

        public Person(string firstName, string lastName) => (FirstName, LastName) = (firstName, lastName);
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
