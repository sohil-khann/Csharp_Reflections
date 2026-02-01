using System;

namespace Reflections.LoggingProxy
{
    public class GreetingService : IGreeting
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
