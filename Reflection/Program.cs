namespace Reflection
{
    using System;
    using System.Data;
    using System.Diagnostics;
    using System.Reflection;

    internal class Program
    {
        private enum MyCustomEnum
        {
            Red = 1, 

            White = 2, 

            Blue = 3
        }

        private static void Main(string[] args)
        {
            // CodeBlock1();
            // CodeBlock2();
            // CodeBlock3();
            // CodeBlock4();
            // CodeBlock5();
            // CodeBlock6();
            // CodeBlock7();
            // CodeBlock8();
            // CodeBlock9();
            // CodeBlock10();
            // CodeBlock11();
            // CodeBlock12();
            // CodeBlock13();
            // CodeBlock14();
            // CodeBlock15();
            // CodeBlock16();
            RealWorldScenario();
        }

        private static void CodeBlock1()
        {
            Assembly myAssembly =
                Assembly.Load("System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089");

            Debug.WriteLine(string.Format("CodeBase: {0}", myAssembly.CodeBase));
            Debug.WriteLine(string.Format("FullName: {0}", myAssembly.FullName));
            Debug.WriteLine(string.Format("GlobalAssemblyCache: {0}", myAssembly.GlobalAssemblyCache));
            Debug.WriteLine(string.Format("ImageRuntimeVersion: {0}", myAssembly.ImageRuntimeVersion));
            Debug.WriteLine(string.Format("Location: {0}", myAssembly.Location));
        }

        private static void CodeBlock2()
        {
            Assembly myAssembly = Assembly.GetExecutingAssembly();

            Type[] myAssemblysTypes = myAssembly.GetTypes();

            foreach (Type myType in myAssemblysTypes)
            {
                Debug.WriteLine(string.Format("myType Name: {0}", myType.Name));
            }
        }

        private static void CodeBlock3()
        {
            Assembly myAssembly =
                Assembly.Load("System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089");

            Module[] myAssemblysModules = myAssembly.GetModules();

            foreach (Module myModule in myAssemblysModules)
            {
                Debug.WriteLine(string.Format("myModule Name: {0}", myModule.Name));
            }
        }

        private static void CodeBlock4()
        {
            Assembly myAssembly =
                Assembly.Load("System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089");

            DataTable dt = (DataTable)myAssembly.CreateInstance("System.Data.DataTable");

            Debug.Print(string.Format("Number of rows: {0}", dt.Rows.Count));
        }

        private static void CodeBlock5()
        {
            Assembly myAssembly =
                Assembly.Load("System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089");

            AssemblyName[] referencedAssemblyNames = myAssembly.GetReferencedAssemblies();

            foreach (AssemblyName assemblyName in referencedAssemblyNames)
            {
                Debug.WriteLine(string.Format("Assembly Name: {0}", assemblyName.Name));
                Debug.WriteLine(string.Format("Assembly Version: {0}", assemblyName.Version));
            }
        }

        private static void CodeBlock6()
        {
            int myIntVariable = 0;
            Type myType = myIntVariable.GetType();

            Debug.WriteLine(string.Format("AssmeblyQualifiedName: {0}", myType.AssemblyQualifiedName));
            Debug.WriteLine(string.Format("FullName: {0}", myType.FullName));
            Debug.WriteLine(string.Format("IsValueType: {0}", myType.IsValueType));
            Debug.WriteLine(string.Format("Name: {0}", myType.Name));
            Debug.WriteLine(string.Format("Namespace: {0}", myType.Namespace));
        }

        private static void CodeBlock7()
        {
            int[,,] myIntArray = new int[5, 6, 7];
            Type myIntArrayType = myIntArray.GetType();
            Debug.Print(string.Format("Array Rank: {0}", myIntArrayType.GetArrayRank()));
        }

        private static void CodeBlock8()
        {
            DataTable myDataTable = new DataTable();
            Type myDataTableType = myDataTable.GetType();
            ConstructorInfo[] myDataTableConstructors = myDataTableType.GetConstructors();

            for (int i = 0; i <= myDataTableConstructors.Length - 1; i++)
            {
                ConstructorInfo constructorInfo = myDataTableConstructors[i];
                Debug.Print(string.Format("\nConstructor #{0}", i + 1));

                ParameterInfo[] parameters = constructorInfo.GetParameters();
                Debug.Print(string.Format("Number Of Parameters: {0}", parameters.Length));

                foreach (ParameterInfo parameter in parameters)
                {
                    Debug.Print(string.Format("Parameter Name: {0}", parameter.Name));
                    Debug.Print(string.Format("Parameter Type: {0}", parameter.ParameterType.Name));
                }
            }
        }

        private static void CodeBlock9()
        {
            Type myCustomEnumType = typeof(MyCustomEnum);

            string[] enumNames = myCustomEnumType.GetEnumNames();

            foreach (string enumName in enumNames)
            {
                Debug.Print(string.Format("Name: {0}", enumName));
            }

            Array enumValues = myCustomEnumType.GetEnumValues();
            foreach (object enumValue in enumValues)
            {
                Debug.Print(string.Format("Enum Value: {0}", enumValue.ToString()));
            }

            for (int i = 1; i <= 3; i++)
            {
                string enumName = myCustomEnumType.GetEnumName(i);
                Debug.Print(string.Format("{0}: {1}", enumName, i));
            }
        }

        private static void CodeBlock10()
        {
            ReflectionExample reflectionExample = new ReflectionExample();
            Type reflectionExampleType = typeof(ReflectionExample);

            FieldInfo[] fields =
                reflectionExampleType.GetFields(
                    BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic
                    | BindingFlags.FlattenHierarchy);

            foreach (FieldInfo field in fields)
            {
                object fieldValue = field.GetValue(reflectionExample);

                Debug.WriteLine(string.Format("Field Name: {0}, Value: {1}", field.Name, fieldValue.ToString()));
            }
        }

        private static void CodeBlock11()
        {
            ReflectionExample reflectionExample = new ReflectionExample();
            Type reflectionExampleType = typeof(ReflectionExample);

            reflectionExampleType.GetField("_privateField", BindingFlags.NonPublic | BindingFlags.Instance)
                .SetValue(reflectionExample, "My New Value");

            Debug.Print(string.Format("Private Field Value: {0}", reflectionExample.PrivateField));
        }

        private static void CodeBlock12()
        {
            ReflectionExample reflectionExample = new ReflectionExample();
            Type reflectionExampleType = typeof(ReflectionExample);

            PropertyInfo[] fields =
                reflectionExampleType.GetProperties(
                    BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic
                    | BindingFlags.FlattenHierarchy);

            foreach (PropertyInfo field in fields)
            {
                object fieldValue = field.GetValue(reflectionExample);

                Debug.WriteLine(string.Format("Field Name: {0}, Value: {1}", field.Name, fieldValue.ToString()));
            }
        }

        private static void CodeBlock13()
        {
            ReflectionExample reflectionExample = new ReflectionExample();
            Type reflectionExampleType = typeof(ReflectionExample);

            MethodInfo methodInfo = reflectionExampleType.GetMethod("Multiply");

            double returnValue = (double)methodInfo.Invoke(reflectionExample, new object[] { 4, 5 });

            Debug.Print(string.Format("Return Value: {0}", returnValue));
        }

        private static void CodeBlock14()
        {
            ReflectionExample reflectionExample = new ReflectionExample();
            Type reflectionExampleType = typeof(ReflectionExample);

            double returnValue =
                (double)
                reflectionExampleType.InvokeMember(
                    "Multiply", 
                    BindingFlags.InvokeMethod, 
                    null, 
                    reflectionExample, 
                    new object[] { 4, 5 });

            Debug.Print(string.Format("Return Value: {0}", returnValue));
        }

        private static void CodeBlock15()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            AssemblyName[] assemblyNames = assembly.GetReferencedAssemblies();

            foreach (AssemblyName assemblyName in assemblyNames)
            {
                Debug.WriteLine(string.Format("\nAssembly Name: {0}", assemblyName.FullName));

                Assembly referencedAssembly = Assembly.Load(assemblyName.FullName);

                object[] attributes = referencedAssembly.GetCustomAttributes(false);

                foreach (object attribute in attributes)
                {
                    Debug.WriteLine(string.Format("\nAttribute Name: {0}", attribute.GetType().Name));

                    // Get the properties of this attribute
                    PropertyInfo[] properties = attribute.GetType().GetProperties();

                    foreach (PropertyInfo property in properties)
                    {
                        Debug.WriteLine(string.Format("{0} : {1}", property.Name, property.GetValue(attribute)));
                    }
                }
            }
        }

        private static void CodeBlock16()
        {
            Type myTestClassType = typeof(MyTestClass);

            MyCustomAttribute attribute =
                (MyCustomAttribute)myTestClassType.GetCustomAttribute(typeof(MyCustomAttribute), false);

            Debug.WriteLine(string.Format("Property1: {0}", attribute.Property1));
            Debug.WriteLine(string.Format("Property2: {0}", attribute.Property2));
            Debug.WriteLine(string.Format("Property3: {0}", attribute.Property3));
        }

        private static void RealWorldScenario()
        {
            Person p = new Person();
            p.GetPerson(1);
            Debug.WriteLine(string.Format("PersonId: {0}", p.PersonId));
            Debug.WriteLine(string.Format("FName: {0}", p.FName));
            Debug.WriteLine(string.Format("LName: {0}", p.LName));
            Debug.WriteLine(string.Format("Address: {0}", p.Address));
            Debug.WriteLine(string.Format("City: {0}", p.City));
            Debug.WriteLine(string.Format("State: {0}", p.State));
            Debug.WriteLine(string.Format("ZipCode: {0}", p.ZipCode));
        }
    }
}