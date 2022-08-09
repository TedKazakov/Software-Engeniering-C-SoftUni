using System;
using System.Collections.Generic;
using System.Linq;
namespace _7._Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	The first element is a string -the name of the person
            //•	The second element a string -the ID of the person
            //•	The third element is an integer - the age of the person
            List<Person> persons = new List<Person>();
            string[] infoAboutPerson = Console.ReadLine().Split();
            while (infoAboutPerson[0] != "End")
            {
                string name = infoAboutPerson[0];
                string id = infoAboutPerson[1];
                int age = int.Parse(infoAboutPerson[2]);
                infoAboutPerson = Console.ReadLine().Split();
                if (persons.Any(person => person.Id == id))
                {
                    person.Age = age;
                    person
                }
                Person person = new Person(name, id, age);
                persons.Add(person);
            }
            foreach (Person person1 in persons.OrderBy(person => person.Age))
            {
                Console.WriteLine($"{person1.Name} with ID: {person1.Id} is {person1.Age} years old.");
            }

        }
    }
    class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }

        public static IEnumerable<Person> OrderBy { get; internal set; }
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
    }
}
