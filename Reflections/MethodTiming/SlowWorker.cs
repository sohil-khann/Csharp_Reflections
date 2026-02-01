using System;
using System.Threading;

namespace Reflections.MethodTiming
{
    public class SlowWorker
    {
        public void FastMethod() => Console.WriteLine("Fast work done.");
        
        public void SlowMethod()
        {
            Console.WriteLine("Starting slow work...");
            Thread.Sleep(500);
            Console.WriteLine("Slow work finished.");
        }
    }
}
