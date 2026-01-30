using System;
using System.Reflection;
namespace AccessPrivateFields
{
    
    public class AccessMain
    {
        public static void ForFields()
        {
            Person person=new Person();
            Type type=Type.GetType("AccessPrivateFields.Person");

           FieldInfo field = type.GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);


        field.SetValue(person,65);
            
                Console.WriteLine("Fields are: "+field.GetValue(person));
                
            

        }
    }
}