using System;
using System.Collections.Generic;
using System.Reflection;

namespace Reflections.ObjectMapper
{
    public class MapperMain
    {
        public static object ToObject(Type clazz, Dictionary<string, object> properties)
        {
            object instance = Activator.CreateInstance(clazz);

            foreach (var prop in properties)
            {
                FieldInfo field = clazz.GetField(prop.Key, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                if (field != null)
                {
                    field.SetValue(instance, Convert.ChangeType(prop.Value, field.FieldType));
                }
                else
                {
                    // Try properties if field not found
                    PropertyInfo property = clazz.GetProperty(prop.Key, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                    if (property != null && property.CanWrite)
                    {
                        property.SetValue(instance, Convert.ChangeType(prop.Value, property.PropertyType));
                    }
                }
            }

            return instance;
        }

        public static void Run()
        {
            var data = new Dictionary<string, object>
            {
                { "Name", "Alice" },
                { "Age", 30 },
                { "Email", "alice@example.com" }
            };

            User user = (User)ToObject(typeof(User), data);
            Console.WriteLine("Mapped Object: " + user);
        }
    }
}
