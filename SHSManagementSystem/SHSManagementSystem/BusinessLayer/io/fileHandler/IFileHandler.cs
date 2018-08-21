using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.io.fileHandler
{
    public interface IFileHandler
    {
        void WriteToTxt(List<string> rawData);

        void AppendToTxt(List<string> rawData);
        List<string> ReadFromTxt();

    }

    [Serializable]
    public class FileCustomException : Exception
    {
        public FileCustomException()
        {

        }
        public FileCustomException(string message)
            : base(message)
        {

        }
        public FileCustomException(string message, Exception inner)
            : base(message, inner)
        {

        }
        public FileCustomException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {

        }
    }
}
