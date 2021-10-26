using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Dima";
            string surname = "Yampolskyi";
            int age = 19;
            int result = 40 - age;
            Console.WriteLine($"Name: " + name + "\nSurname: " + surname + "\nAge: " + age + "\nYears till 40: " + result);
        }
    }
}
