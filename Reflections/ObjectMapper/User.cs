using System;

namespace Reflections.ObjectMapper
{
    public class User
    {
        public string Name;
        public int Age;
        public string Email;

        public override string ToString() => $"User(Name={Name}, Age={Age}, Email={Email})";
    }
}
