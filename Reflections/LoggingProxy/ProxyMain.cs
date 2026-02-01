using System;

namespace Reflections.LoggingProxy
{
    public class ProxyMain
    {
        public static void Run()
        {
            IGreeting realService = new GreetingService();
            IGreeting proxiedService = LoggingProxy<IGreeting>.Create(realService);

            Console.WriteLine("Calling method via proxy:");
            proxiedService.SayHello("Sohil");
        }
    }
}
