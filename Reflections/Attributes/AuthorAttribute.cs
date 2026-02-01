using System;

namespace Reflections.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class AuthorAttribute : Attribute
    {
        public string Name { get; }
        public AuthorAttribute(string name)
        {
            Name = name;
        }
    }
}
