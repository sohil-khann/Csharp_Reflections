/*3. Invoke Private Method: Define a class Calculator with a private method Multiply(int
a, int b). Use Reflection to invoke this method and display the result.
*/
using System;
using System.Reflection;
namespace InvokePrivateMethod
{
    public class CalcMain// main class
    {
        public static void ForMethod()//helper method
        {
           Calculator calc = new Calculator();
Type type = calc.GetType();
MethodInfo method = type.GetMethod("Multiply",BindingFlags.NonPublic | BindingFlags.Instance); //getting method info
int result = (int)method.Invoke(calc, new object[] { 5, 10}); //method invoke
Console.WriteLine(" Result: " + result); //result

        }
    }

}