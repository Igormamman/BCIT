using System;

namespace Reflection
{
 
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class TestAttribute : Attribute
    {
        public TestAttribute() { }
        public TestAttribute(string DescriptionParam)
        {
            Description = DescriptionParam;
        }

        public string Description { get; set; }
    }
}
