using System;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Collections;
using System.Diagnostics.CodeAnalysis;


namespace CompanyName.ProjectName.ServiceName.CustomException
{
    [ExcludeFromCodeCoverage]
    public class ImportFileExcelException : Exception, ISerializable
    {
        public override string Message
        {
            get
            {
                return "Import dei dati errato,alcuni dati hanno valori non consentiti";
            }
        }

        public ImportFileExcelException()
        {
            // Add implementation.
        }
        public ImportFileExcelException(string message)
        {
            // Add implementation.
        }
        public ImportFileExcelException(string message, Exception inner)
        {
            // Add implementation.
        }
        // This constructor is needed for serialization.
        protected ImportFileExcelException(SerializationInfo info, StreamingContext context)
        {
            // Add implementation.
        }
    }
}
