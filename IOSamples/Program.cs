namespace IOSamples
{
    using System.Diagnostics;
    using System.IO;
    using System.Text;

    public class Program
    {
        private static void Main(string[] args)
        {
            //GetFileInfoSample();

            //GetDirectoryInfoSample();

            //GetFilesSample();

            GetFileStreamSample();

            //GetStreamWriterSample();
        }

        private static void GetStreamWriterSample()
        {
            // StreamWriter
            StreamWriter streamWriter = new StreamWriter(@"d:\Samples\StreamWriter.txt");

            streamWriter.WriteLine("ABC");
            streamWriter.Write(true);
            streamWriter.Write(1);

            streamWriter.Close();

            FileStream fileStream1 = new FileStream(@"d:\Samples\BinaryWriter.txt", FileMode.Create);
            BinaryWriter binaryWriter = new BinaryWriter(fileStream1);

            binaryWriter.Write("ABC");
            binaryWriter.Write(true);
            binaryWriter.Write(1);

            binaryWriter.Close();

            FileStream fileStream2 = new FileStream(@"d:\Samples\BinaryWriter.txt", FileMode.Open);
            BinaryReader binaryReader = new BinaryReader(fileStream2);

            string abs = binaryReader.ReadString();
            bool b = binaryReader.ReadBoolean();
            int ii = binaryReader.ReadInt32();

            binaryReader.Close();
        }

        private static void GetFileStreamSample()
        {
            ////FileStream
            FileStream fileStream = new FileStream(
                @"d:\Samples\Numbers.txt", 
                FileMode.Truncate, 
                FileAccess.Write, 
                FileShare.None);

            for (int i = 0; i < 10; i++)
            {
                byte[] number = new UTF8Encoding(true).GetBytes(i.ToString());
                fileStream.Write(number, 0, number.Length);
            }

            fileStream.Close();

            StreamReader streamReader = new StreamReader(@"d:\Samples\Numbers.txt");
            Debug.WriteLine("Char by Char");
            while (!streamReader.EndOfStream)
            {
                Debug.WriteLine((char)streamReader.Read());
            }

            streamReader.Close();

            streamReader = new StreamReader(@"d:\Samples\Numbers.txt");
            Debug.WriteLine("Line by line");
            while (!streamReader.EndOfStream)
            {
                Debug.WriteLine(streamReader.ReadLine());
            }

            streamReader.Close();

            streamReader = new StreamReader(@"d:\Samples\Numbers.txt");
            Debug.WriteLine("Entire file");
            Debug.WriteLine(streamReader.ReadToEnd());

            StringReader stringReader = new StringReader("Hello\nGoodbye");
            int pos = stringReader.Read();
            while (pos != -1)
            {
                Debug.WriteLine("{0}", (char)pos);
                pos = stringReader.Read();
            }
            stringReader.Close();
        }

        private static void GetFilesSample()
        {
            // DirectoryInfo
            DirectoryInfo directoryInfo = new DirectoryInfo(@"d:\");

            ////Files
            Debug.WriteLine("Files");
            foreach (DirectoryInfo di in directoryInfo.GetDirectories())
            {
                Debug.WriteLine(di.Name);
            }
        }

        private static void GetDirectoryInfoSample()
        {
            // DirectoryInfo
            DirectoryInfo directoryInfo = new DirectoryInfo(@"d:\");

            ////Directories
            Debug.WriteLine("Directories");
            foreach (FileInfo fileInfo1 in directoryInfo.GetFiles())
            {
                Debug.WriteLine(fileInfo1.Name);
            }

            directoryInfo = null;
        }

        private static void GetFileInfoSample()
        {
            // FileInfo
            FileInfo fileInfo = new FileInfo(@"d:\Samples\HelloWorld.txt");
            Debug.WriteLine(fileInfo.Name);
        }
    }
}