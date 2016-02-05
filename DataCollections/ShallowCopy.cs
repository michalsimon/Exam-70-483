namespace DataCollections
{
    using System.Diagnostics;

    public class ShallowCopy
    {
        public static void CloneSample1()
        {
            Person[] orginal = new Person[1];
            orginal[0] = new Person() { FName = "John" };
            Person[] clone = (Person[])orginal.Clone();
            clone[0].FName = "Mary";
            Debug.WriteLine("Original name " + orginal[0].FName);
            Debug.WriteLine("Clone name " + clone[0].FName);
        }

        public static void CloneSample2()
        {
            Person[] orginal = new Person[1];
            orginal[0] = new Person() { FName = "John" };
            Person[] clone = (Person[])orginal.Clone();
            clone[0] = new Person() { FName = "Bob" };
            Debug.WriteLine("Original name " + orginal[0].FName);
            Debug.WriteLine("Clone name " + clone[0].FName);
        }
    }
}