using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    using Encryption.Asymmetric;
    using Encryption.Hashing;
    using Encryption.ProtectingData;
    using Encryption.Symmetric;

    class Program
    {
        static void Main(string[] args)
        {
            TripleDESSample.Run();
            AesManagedSample.Run();
            RSASample.Run();
            SHASample.Run();
            ProtectDataSample.Run();
        }
    }
}
