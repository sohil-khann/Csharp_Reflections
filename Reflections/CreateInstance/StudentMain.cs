/*4. Dynamically Create Objects: Write a program to create an instance of a Student class
dynamically using Reflection without using the new keyword.
*/
using System;
using System.Reflection;
namespace CreateInstance
{
    public class StudentMain//helper class
    {
        public static void ForInstance() //helper method
        {
            
            Type type=Type.GetType("CreateInstance.Student");

            Object obj=Activator.CreateInstance(type); //instance creation
Student student=(Student)obj;
student.Name="Sohil";
student.Display();

        }
    }
}