/*3. Invoke Private Method: Define a class Calculator with a private method Multiply(int
a, int b). Use Reflection to invoke this method and display the result.
*/
using System;
using System.Reflection;
namespace InvokePrivateMethod
{
    public class Calculator //Calculator class
    {
        private int Multiply(int a,int b) //private method
        {
            return a*b;
        }
        
    }

}