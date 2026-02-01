using System;

namespace Reflections.Attributes
{
    public class AttributeMain
    {
        public static void Run()
        {
            Type type = typeof(SampleClass);
            var attribute = (AuthorAttribute)Attribute.GetCustomAttribute(type, typeof(AuthorAttribute));

            if (attribute != null)
            {
                Console.WriteLine($"Class: {type.Name}, Author: {attribute.Name}");
            }
            else
            {
                Console.WriteLine("Attribute not found.");
            }
        }
    }
}
