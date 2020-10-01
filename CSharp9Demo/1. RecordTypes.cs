using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9Demo
{
    internal sealed class RecordTypes
    {
        /*
         * Records are immutable reference types that provides synthesized methods to provide value semantics for equality.
         */

        public record Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public Person(string firstName, string lastName) => (FirstName, LastName) = (firstName, lastName);
        }

        public record Teacher : Person
        {
            public string Subject { get; set; }

            public Teacher(string firstName, string lastName, string subject)
                : base(firstName, lastName) => Subject = subject;
        }

        public static void Run()
        {
            Person person1 = new Person("Stanislav", "Orlov");
            Person person2 = new Person("Stanislav", "Orlov");

            Console.WriteLine(person1 == person2);      //false

            person1.FirstName = "Vladyslav";
        }
    }
}
