namespace DataCollections
{
    using System.Diagnostics;

    public class ArraySamples
    {
        public static void Sample1()
        {
            int[] mySet = new int[5];

            mySet[0] = 1;
            mySet[1] = 2;
            mySet[2] = 3;
            mySet[3] = 4;
            mySet[4] = 5;

            foreach (int i in mySet)
            {
                Debug.WriteLine(i.ToString());
            }
        }

        public static void Sample2()
        {
            int[,] mySet = new int[3, 2];

            mySet[0, 0] = 1;
            mySet[0, 1] = 2;
            mySet[1, 0] = 3;
            mySet[1, 1] = 4;
            mySet[2, 0] = 5;
            mySet[2, 1] = 6;

            for (int i = 0; i < mySet.Length/mySet.Rank; i++)
            {
                for (int j = 0; j < mySet.Rank; j++)
                {
                    Debug.WriteLine(mySet[i,j].ToString());
                }
            }
        }
    }
}