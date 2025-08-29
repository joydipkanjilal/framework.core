using System.Runtime.Serialization;

namespace Core.Exception
{
    [Serializable]
    public abstract class BaseException : System.Exception
    {
        protected String ExceptionMessage
        {
            get;
            set;
        }

        protected int ExceptionMessageID
        {
            get;
            set;
        }

        public BaseException()
        {
        }

        public BaseException(string message)
           : base(message)
        {
        }

        public BaseException(string message,
            System.Exception innerException)
            : base(message, innerException)
        {
        }

        protected BaseException(SerializationInfo info,
            StreamingContext context)
            : base(info, context)
        {
        }
    }
}