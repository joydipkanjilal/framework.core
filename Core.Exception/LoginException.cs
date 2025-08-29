using System.Runtime.Serialization;

namespace Core.Exception
{
    [Serializable]
    public sealed class LoginException : BaseException
    {
        public string UserName
        {
            get;
            set;
        }

        public LoginException()
        {
        }

        public LoginException(string message)
            : base(message)
        {
        }

        public LoginException(string message,
            System.Exception innerException)
            : base(message, innerException)
        {
        }

        protected LoginException(SerializationInfo info,
            StreamingContext context)
            : base(info, context)
        {
            if (info != null)
            {
                this.UserName = info.GetString("UserName");
            }
        }

        public override void GetObjectData(SerializationInfo info,
            StreamingContext context)
        {
            base.GetObjectData(info, context);

            if (info != null)
            {
                info.AddValue("UserName", this.UserName);
            }
        }
    }
}