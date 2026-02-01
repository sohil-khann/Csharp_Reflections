using System;
using System.Reflection;

namespace Reflections.LoggingProxy
{
    // Since DispatchProxy is available in .NET, we use it for dynamic proxying
    public class LoggingProxy<T> : DispatchProxy
    {
        private T _target;

        protected override object? Invoke(MethodInfo? targetMethod, object?[]? args)
        {
            if (targetMethod != null)
            {
                Console.WriteLine($"[LOG] Executing method: {targetMethod.Name} at {DateTime.Now}");
            }
            
            return targetMethod?.Invoke(_target, args);
        }

        public static T Create(T target)
        {
            object proxy = Create<T, LoggingProxy<T>>();
            ((LoggingProxy<T>)proxy)._target = target;
            return (T)proxy;
        }
    }
}
