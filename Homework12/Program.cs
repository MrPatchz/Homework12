using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create list and all the people
            List<Person> mylist = new List<Person>();
            Person p1 = new Person("Mark", 12, 6.2);
            Person p2 = new Person("Jim", 4, 3.5);
            Person p3 = new Person("Bob", 6, 5.4);
            Person p4 = new Person("Jack", 6, 4.5);
            Person p5 = new Person("Tom", 10, 5.6);
            Person p6 = new Person("Bill", 11, 6.5);
            Person p7 = new Person("Michael", 22, 5.8);
            Person p8 = new Person("Jimmy", 14, 5.11);
            Person p9 = new Person("Karen", 16, 6.0);
            Person p10 = new Person("Sally", 2, 5.7);
            //add them all to list
            mylist.Add(p1);
            mylist.Add(p2);
            mylist.Add(p3);
            mylist.Add(p4);
            mylist.Add(p5);
            mylist.Add(p6);
            mylist.Add(p7);
            mylist.Add(p8);
            mylist.Add(p9);
            mylist.Add(p10);
            //from pa in mylist select a
            IEnumerable<Person> personQuery = from a in mylist
                                                where a.Age <= 12
                                                select a;
            Console.WriteLine("People under 12:");
            foreach (Person person in personQuery)
            {
                Console.WriteLine(person.toString());
            }
            //2nd requirement
            //count
            int personCount = (from pa in mylist
                               orderby pa.Name, pa.Height, pa.Age
                               select pa).Count();
            double average = 0;
            double sum = 0;
            foreach (var pp in mylist)
            {
                sum += pp.Height;
            }
            average = sum / personCount;
            personQuery = from a in mylist
                          where a.Height >= average
                          select a;
            Console.WriteLine("\nPeople over the average height:");
            foreach (Person person in personQuery)
            {
                Console.WriteLine(person.toString());
            }
        }
    }
    public class Person
    {
        string name;
        int age;
        double height;
        public Person(string name, int age, double height)
        {
            this.Name = name;
            this.Age = age;
            this.Height = height;
        }

        public double Height { get => height; set => height = value; }
        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }

        public string toString()
        {
            return Name + " with an age of " + Age + " and a heigh of " + Height;
        }
    }

}
