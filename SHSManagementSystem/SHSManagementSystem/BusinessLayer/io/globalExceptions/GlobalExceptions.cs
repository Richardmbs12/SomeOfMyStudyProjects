using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.io.globalExceptions
{
    public class UnsupportedSearchCriteria : Exception
    {
        public UnsupportedSearchCriteria()
        {

        }
        public UnsupportedSearchCriteria(string message)
            : base(message)
        {

        }
        public UnsupportedSearchCriteria(string message, Exception inner)
            : base(message, inner)
        {

        }
        public UnsupportedSearchCriteria(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {

        }
    }
    public class RequestNotValid : Exception
    {
        public RequestNotValid()
        {

        }

        public RequestNotValid(string message)
            : base(message)
        {

        }

        public RequestNotValid(string message, Exception innerException)
            : base(message, innerException)
        {

        }
        public RequestNotValid(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {

        }
    }
    public class UnSupportedSearchIdentifier : Exception
    {
        public UnSupportedSearchIdentifier()
        {

        }
        public UnSupportedSearchIdentifier(string message)
            : base(message)
        {

        }
        public UnSupportedSearchIdentifier(string message, Exception innerException)
            : base(message, innerException)
        {

        }
        public UnSupportedSearchIdentifier(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {

        }
    }
}
