using System;

namespace Reflections.StaticFields
{
    public class Configuration
    {
        private static string API_KEY = "DEFAULT_KEY";

        public static void PrintKey()
        {
            Console.WriteLine($"Current API_KEY: {API_KEY}");
        }
    }
}
