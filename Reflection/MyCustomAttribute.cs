namespace Reflection
{
    using System;

    [System.AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class MyCustomAttribute : System.Attribute
    {
        public enum MyCustomAttributeEnum
        {
            Red, 

            White, 

            Blue
        }

        public bool Property1 { get; set; }

        public string Property2 { get; set; }

        public MyCustomAttributeEnum Property3 { get; set; }
    }
}