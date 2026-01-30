/*2. Access Private Field: Create a class Person with a private field age. Use Reflection to
modify and retrieve its value.
*/

using System;
using System.Reflection;
namespace AccessPrivateFields
{
    public class Person
    {
        private int age = 25;

    

        public void DisplayAge()
        {
            Console.WriteLine("Age: " + age);
       
        }
    }

    
    }
