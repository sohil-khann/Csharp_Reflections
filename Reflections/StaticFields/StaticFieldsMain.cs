using System;
using System.Reflection;

namespace Reflections.StaticFields
{
    public class StaticFieldsMain
    {
        public static void Run()
        {
            Type type = typeof(Configuration);
            FieldInfo field = type.GetField("API_KEY", BindingFlags.NonPublic | BindingFlags.Static);

            if (field != null)
            {
                Console.WriteLine("Original Value:");
                Configuration.PrintKey();

                field.SetValue(null, "NEW_SECURE_API_KEY_123");

                Console.WriteLine("Modified Value via Reflection:");
                Configuration.PrintKey();
            }
            else
            {
                Console.WriteLine("Static field API_KEY not found.");
            }
        }
    }
}
