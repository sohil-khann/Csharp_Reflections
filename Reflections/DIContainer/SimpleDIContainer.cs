using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Reflections.DIContainer
{
    public class SimpleDIContainer
    {
        private readonly Dictionary<Type, object> _services = new Dictionary<Type, object>();

        public void Register<T>(T instance)
        {
            _services[typeof(T)] = instance;
        }

        public T CreateInstance<T>() where T : new()
        {
            T instance = new T();
            Type type = typeof(T);

            // Inject into fields
            var fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
                             .Where(f => f.GetCustomAttribute<InjectAttribute>() != null);

            foreach (var field in fields)
            {
                if (_services.TryGetValue(field.FieldType, out object service))
                {
                    field.SetValue(instance, service);
                }
            }

            // Inject into properties
            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
                                 .Where(p => p.GetCustomAttribute<InjectAttribute>() != null && p.CanWrite);

            foreach (var prop in properties)
            {
                if (_services.TryGetValue(prop.PropertyType, out object service))
                {
                    prop.SetValue(instance, service);
                }
            }

            return instance;
        }
    }
}
