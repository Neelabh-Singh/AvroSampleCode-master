using Avro.IO;
using Avro.Specific;
using com.shanidgafur.error;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvroSampleCode
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime EpochBeginDate = new DateTime(1970, 1, 1);

            //Populate the code generated Avro POCOs with data to be serialized
            ErrorDetails details = new ErrorDetails
            {
                Category = "DBConnectivity",
                Severity = "FATAL",
                Timestamp = 
                    (long)(DateTime.Now.ToUniversalTime() - EpochBeginDate.ToUniversalTime()).TotalSeconds
            };
            Error apperror = new Error
            {
                Details = details,
                Appname = "MyApplication",
                Id = 123
            };

            //Setup File Stream for serialization
            string filelocation = @"c:\temp\avro.bin";
            var stream = 
                new FileStream(filelocation, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Write);


            //Endode the stream and write to file system
            Avro.IO.Encoder encoder = new BinaryEncoder(stream);
            SpecificDefaultWriter writer = new Avro.Specific.SpecificDefaultWriter(apperror.Schema);
            writer.Write<Error>(apperror, encoder);

            stream.Close();
        }
    }
}
