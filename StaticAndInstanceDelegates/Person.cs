namespace StaticAndInstanceDelegates
{
    public class Person
    {
        public string Name;

        // A method that returns a string.
        public delegate string GetStringDelegate();

        // A static method.
        public static string StaticName()
        {
            return "Static";
        }

        // Return this instance's Name.
        public string GetName()
        {
            return this.Name;
        }

        // Variables to hold GetStringDelegates.
        public GetStringDelegate StaticMethod;
        public GetStringDelegate InstanceMethod;
    }
}