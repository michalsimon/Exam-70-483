using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumingData
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunADONETSamples();
        }

        private static void RunADONETSamples()
        {
            ADONETSamples.CommandExecuteNonQueryText();
            ADONETSamples.CommandExecuteNonQueryStoredProcedure();
            ADONETSamples.CommandExecuteReader();
            ADONETSamples.CommandExecuteScalar();
            ADONETSamples.CommandExecuteXmlReader();
            ADONETSamples.DataSetPopulate();
            ADONETSamples.DataSetInsert();
            ADONETSamples.DataSetUpdateDelete();
        }
    }
}
