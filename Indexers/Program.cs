using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    public class IPAddress
    {
        private int[] ip;

        public int this[int index]
        {
            get
            {
                return this.ip[index];
            }
            set
            {
                if (value == 0 || value == 1)
                {
                    this.ip[index] = value;
                }
                else
                {
                    throw new Exception("Invalid value");
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IPAddress myIP = new IPAddress();

            // initialize the IP address to all zeros
            for (int i = 0; i < 32; i++)
            {
                myIP[i] = 0;
            }
        }
    }
}
