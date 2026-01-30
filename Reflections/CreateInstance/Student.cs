/*4. Dynamically Create Objects: Write a program to create an instance of a Student class
dynamically using Reflection without using the new keyword.
*/
using System;
using System.Reflection;
namespace CreateInstance
{
    public class Student //main class
    {
        public string Name { get; set; }//properties
    public void Display() => Console.WriteLine($"Student Name: {Name}");

    }
}