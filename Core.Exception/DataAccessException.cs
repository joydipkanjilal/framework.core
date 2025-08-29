using System.Runtime.Serialization;

namespace Core.Exception
{
    [Serializable]
    public sealed class DataAccessException : BaseException
    {
        public DataAccessException()
        {
        }

        public DataAccessException(string message)
            : base(message)
        {
        }

        public DataAccessException(string message,
            System.Exception innerException)
            : base(message, innerException)
        {
        }

        protected DataAccessException(SerializationInfo info,
            StreamingContext context)
            : base(info, context)
        {
        }

        public override void GetObjectData(SerializationInfo info,
            StreamingContext context)
        {
            base.GetObjectData(info, context);
        }
    }
}