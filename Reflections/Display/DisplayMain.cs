using System;

using System.Reflection;
namespace Display{
public class DisplayMain
{
            
public void ForConstructor(Type type)
    {
        
        ConstructorInfo[] constructors = type.GetConstructors(BindingFlags.Public| BindingFlags.NonPublic | BindingFlags.Instance |BindingFlags.Static|BindingFlags.DeclaredOnly);
        foreach (ConstructorInfo constructor in constructors)
        {
            try
            {
                Console.WriteLine("Constructor: " + constructor.Invoke(null));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Constructor: " + ex.Message);
            }
        }

        }
    public void ForFields(Type type)
    {
        


FieldInfo[] field = type.GetFields(BindingFlags.Public| BindingFlags.NonPublic | BindingFlags.Instance |BindingFlags.Static|BindingFlags.DeclaredOnly);
foreach(var item in field)
        {
            

Console.WriteLine("Field:" + item.Name);
        }
    }
    public void ForMethod(Type type)
    {
        

MethodInfo[] methods = type.GetMethods(BindingFlags.Public| BindingFlags.NonPublic | BindingFlags.Instance |BindingFlags.Static|BindingFlags.DeclaredOnly);

foreach(MethodInfo item in methods){
Console.WriteLine("methods:" + item.Name);
}
        
    }

}
}