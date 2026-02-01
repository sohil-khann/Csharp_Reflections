
using System.Reflection;
using Display;
using AccessPrivateFields;
using InvokePrivateMethod;
using CreateInstance;
using DynamicMathInvoke;
using Reflections.Attributes;
using Reflections.StaticFields;
using Reflections.ObjectMapper;
using Reflections.JsonGenerator;
using Reflections.LoggingProxy;
using Reflections.DIContainer;
using Reflections.MethodTiming;

//problem 1:
// DisplayMain displayMain=new DisplayMain();
// "Display.DisplayInfo" is the fully qualified name of the class
// Type type = Type.GetType(Console.ReadLine());
// displayMain.ForFields(type);
// displayMain.ForMethod(type);
// displayMain.ForConstructor(type);

// Problem 2
// AccessMain.ForFields();

// problem 3
// CalcMain.ForMethod();

// Problem 4
// StudentMain.ForInstance();

// problem 5
// OperMain.ForInvocation(); 

// Task 6: Retrieve Attributes at Runtime
Console.WriteLine("\n--- Task 6: Attributes ---");
AttributeMain.Run();

// Task 7: Access and Modify Static Fields
Console.WriteLine("\n--- Task 7: Static Fields ---");
StaticFieldsMain.Run();

// Advanced 1: Custom Object Mapper
Console.WriteLine("\n--- Advanced 1: Object Mapper ---");
MapperMain.Run();

// Advanced 2: Generate JSON Representation
Console.WriteLine("\n--- Advanced 2: JSON Generator ---");
JsonMain.Run();

// Advanced 3: Custom Logging Proxy
Console.WriteLine("\n--- Advanced 3: Logging Proxy ---");
ProxyMain.Run();

// Advanced 4: Dependency Injection
Console.WriteLine("\n--- Advanced 4: DI Container ---");
DIMain.Run();

// Advanced 5: Method Execution Timing
Console.WriteLine("\n--- Advanced 5: Method Timing ---");
TimingMain.Run();
