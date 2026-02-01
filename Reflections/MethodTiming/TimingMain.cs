using System;
using System.Diagnostics;
using System.Reflection;

namespace Reflections.MethodTiming
{
    public class TimingMain
    {
        public static void MeasureTime(object obj, string methodName)
        {
            Type type = obj.GetType();
            MethodInfo method = type.GetMethod(methodName);

            if (method != null)
            {
                Stopwatch sw = Stopwatch.StartNew();
                method.Invoke(obj, null);
                sw.Stop();
                Console.WriteLine($"Method '{methodName}' executed in {sw.ElapsedMilliseconds}ms");
            }
            else
            {
                Console.WriteLine($"Method '{methodName}' not found.");
            }
        }

        public static void Run()
        {
            SlowWorker worker = new SlowWorker();
            
            Console.WriteLine("Measuring FastMethod:");
            MeasureTime(worker, "FastMethod");

            Console.WriteLine("\nMeasuring SlowMethod:");
            MeasureTime(worker, "SlowMethod");
        }
    }
}
