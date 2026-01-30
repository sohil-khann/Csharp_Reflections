/*5. Dynamic Method Invocation: Define a class MathOperations with multiple public
methods (Add, Subtract, Multiply). Use Reflection to dynamically call any method
based on user input.
*/
using System;
using System.Reflection;
namespace DynamicMathInvoke
{
    public class MathOperations
    {
        
        public int Add(int a,int b)
        {
            return a+b;
            
        }  
        public int Subtract(int a,int b)
        {
            return a-b;
        }
        public int Multiply(int a,int b)
        {
            return a*b;
        }
        
          }
}
