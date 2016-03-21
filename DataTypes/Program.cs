namespace ValueTypes
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            // ValueTypeSample();
            // ValueTypeAliasSample();
            // StructSample();
            // StructSample2();
            EnumSaple();

            Console.ReadLine();
        }

        private enum Months
        {
            Jan = 1,

            Feb,

            Mar,

            Apr,

            May,

            Jun,

            Jul,

            Aug,

            Sept,

            Oct,

            Nov,

            Dec
        };

        private static void EnumSaple()
        {
            string name = Enum.GetName(typeof(Months), 8);
            Console.WriteLine("The 8th month in the enum is " + name);

            Console.WriteLine("The underlying values of the Months enum:");
            foreach (int values in Enum.GetValues(typeof(Months)))
            {
                Console.WriteLine(values);
            }
        }

        public struct Book
        {
            public string title;

            public string category;

            public string author;

            public int numPages;

            public int currentPage;

            public double ISBN;

            public string coverStyle;

            public Book(
                string title, 
                string category, 
                string author, 
                int numPages, 
                int currentPage, 
                double isbn, 
                string cover)
            {
                this.title = title;
                this.category = category;
                this.author = author;
                this.numPages = numPages;
                this.currentPage = currentPage;
                this.ISBN = isbn;
                this.coverStyle = cover;
            }

            public void nextPage()
            {
                if (this.currentPage != this.numPages)
                {
                    this.currentPage++;
                    Console.WriteLine("Current page is now: " + this.currentPage);
                }
                else
                {
                    Console.WriteLine("At end of book.");
                }
            }

            public void prevPage()
            {
                if (this.currentPage != 1)
                {
                    this.currentPage--;
                    Console.WriteLine("Current page is now: " + this.currentPage);
                }
                else
                {
                    Console.WriteLine("At the beginning of the book.");
                }
            }
        }

        private static void StructSample2()
        {
            Book myBook = new Book(
                "MCSD Certification Toolkit (Exam 70-483)", 
                "Certification", 
                "Covaci, Tiberiu", 
                648, 
                1, 
                81118612095, 
                "Soft Cover");
            Console.WriteLine(myBook.title);
            Console.WriteLine(myBook.category);
            Console.WriteLine(myBook.author);
            Console.WriteLine(myBook.numPages);
            Console.WriteLine(myBook.currentPage);
            Console.WriteLine(myBook.ISBN);
            Console.WriteLine(myBook.coverStyle);
            myBook.nextPage();
            myBook.prevPage();
        }

        public struct Student
        {
            public string firstName;

            public string lastName;

            public char initial;

            public double score1;

            public double score2;

            public double score3;

            public double score4;

            public double score5;

            public double average;
        }

        private static void StructSample()
        {
            // create a new instance of the Student struct
            Student myStudent = new Student();

            // assign some values to the properties of myStudent
            myStudent.firstName = "Fred";
            myStudent.lastName = "Jones";
            myStudent.score1 = 89;
            myStudent.score2 = 95;
            Console.Write("Student " + myStudent.firstName + " " + myStudent.lastName);
            Console.Write(" scored " + myStudent.score1 + " on his/her first test. ");

            // illegal statement, cannot use the type directly
            // Visual Studio will indicate that an object reference is required
            // Student.firstName = "Fail";
        }

        private static void ValueTypeAliasSample()
        {
            // create a variable to hold a value type using the alias form
            // but don’t assign a variable
            int myInt;
            int myNewInt = new int();

            // create a variable to hold a .NET value type
            // this type is the .NET version of the alias form int
            // note the use of the keyword new, we are creating an object from 
            // the System.Int32 class
            int myInt32 = new System.Int32();

            // you will need to comment out this first Console.WriteLine statement
            // as Visual Studio will generate an error about using an unassigned
            // variable.  This is to prevent using a value that was stored in the
            // memory location prior to the creation of this variable
            // Console.WriteLine(myInt);

            // print out the default value assigned to an int variable
            // that had no value assigned previously
            Console.WriteLine(myNewInt);

            // this statement will work fine and will print out the default value for
            // this type, which in this case is 0
            Console.WriteLine(myInt32);
        }

        private static void ValueTypeSample()
        {
            // declare some numeric data types
            int myInt;
            double myDouble;
            byte myByte;
            char myChar;
            decimal myDecimal;
            float myFloat;
            long myLong;
            short myShort;
            bool myBool;

            // assign values to these types and then
            // print them out to the console window
            // also use the sizeOf operator to determine
            // the number of bytes taken up be each type
            myInt = 5000;
            Console.WriteLine("Integer");
            Console.WriteLine(myInt);
            Console.WriteLine(myInt.GetType());
            Console.WriteLine(sizeof(int));
            Console.WriteLine();

            myDouble = 5000.0;
            Console.WriteLine("Double");
            Console.WriteLine(myDouble);
            Console.WriteLine(myDouble.GetType());
            Console.WriteLine(sizeof(double));
            Console.WriteLine();

            myByte = 254;
            Console.WriteLine("Byte");
            Console.WriteLine(myByte);
            Console.WriteLine(myByte.GetType());
            Console.WriteLine(sizeof(byte));
            Console.WriteLine();

            myChar = 'r';
            Console.WriteLine("Char");
            Console.WriteLine(myChar);
            Console.WriteLine(myChar.GetType());
            Console.WriteLine(sizeof(byte));
            Console.WriteLine();

            myDecimal = 20987.89756M;
            Console.WriteLine("Decimal");
            Console.WriteLine(myDecimal);
            Console.WriteLine(myDecimal.GetType());
            Console.WriteLine(sizeof(byte));
            Console.WriteLine();

            myFloat = 254.09F;
            Console.WriteLine("Float");
            Console.WriteLine(myFloat);
            Console.WriteLine(myFloat.GetType());
            Console.WriteLine(sizeof(byte));
            Console.WriteLine();

            myLong = 2544567538754;
            Console.WriteLine("Long");
            Console.WriteLine(myLong);
            Console.WriteLine(myLong.GetType());
            Console.WriteLine(sizeof(byte));
            Console.WriteLine();

            myShort = 3276;
            Console.WriteLine("Short");
            Console.WriteLine(myShort);
            Console.WriteLine(myShort.GetType());
            Console.WriteLine(sizeof(byte));
            Console.WriteLine();

            myBool = true;
            Console.WriteLine("Boolean");
            Console.WriteLine(myBool);
            Console.WriteLine(myBool.GetType());
            Console.WriteLine(sizeof(byte));
            Console.WriteLine();
        }
    }
}