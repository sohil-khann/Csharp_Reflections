/*5. Dynamic Method Invocation: Define a class MathOperations with multiple public
methods (Add, Subtract, Multiply). Use Reflection to dynamically call any method
based on user input.
*/
using System;
using System.Reflection;
using InvokePrivateMethod;
namespace DynamicMathInvoke
{
    public class OperMain
    {
        public static void ForInvocation()
        {
            MathOperations cm = new MathOperations();

            // Correct namespace and class name
            Type type = typeof(MathOperations);

            Console.Write("Enter method name (Add/Subtract/Multiply): ");
            string input = Console.ReadLine() ?? "";

            // Get method info (only public instance methods)
            MethodInfo info = type.GetMethod(input, BindingFlags.Public | BindingFlags.Instance);

            if (info != null)
            {
                int result = (int)info.Invoke(cm, new object[] { 5, 10 });
                Console.WriteLine("Result: " + result);
            }
            else
            {
                Console.WriteLine("Method not found!");
            }



        }
    }

}