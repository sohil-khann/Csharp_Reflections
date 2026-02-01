using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Reflections.JsonGenerator
{
    public class JsonMain
    {
        public static string ToJson(object obj)
        {
            if (obj == null) return "null";

            Type type = obj.GetType();
            if (type.IsPrimitive || obj is string || obj is decimal)
            {
                return obj is string ? $"\"{obj}\"" : obj.ToString().ToLower();
            }

            StringBuilder sb = new StringBuilder();
            sb.Append("{");

            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic);
            List<string> pairs = new List<string>();

            foreach (var field in fields)
            {
                object value = field.GetValue(obj);
                string valueStr = value == null ? "null" : 
                                 (field.FieldType == typeof(string) ? $"\"{value}\"" : 
                                 (field.FieldType == typeof(bool) ? value.ToString().ToLower() : value.ToString()));
                
                pairs.Add($"\"{field.Name}\": {valueStr}");
            }

            sb.Append(string.Join(", ", pairs));
            sb.Append("}");

            return sb.ToString();
        }

        public static void Run()
        {
            Product p = new Product();
            string json = ToJson(p);
            Console.WriteLine("Generated JSON-like string:");
            Console.WriteLine(json);
        }
    }
}
