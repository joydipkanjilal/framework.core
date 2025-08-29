namespace Core.Logging
{
    internal class AsyncLogManager
    {
        public int Operation
        {
            get;
            set;
        }

        public IAsyncResult BeginLog(object objParameter, AsyncCallback callBack, object state)
        {
            Task<object> task = new Task<object>((obj) =>
            {
                return Log(objParameter);
            }, state);

            if (callBack != null)
            {
                task.ContinueWith((tsk) => callBack(tsk));
            }

            task.Start();
            return task;
        }

        public virtual object EndLog(IAsyncResult result)
        {
            object data = null;
            Task<object> task = result as Task<object>;

            if (task != null)
            {
                data = task.Result;
            }

            return data;
        }

        public void Callback(IAsyncResult result)
        {
            EndLog(result);
        }

        public object Log(object obj)
        {
            return null;
        }
    }

    public static class LogHelper
    {
        public static string Comments
        {
            get;
            set;
        }

        public static string EventLogStatus
        {
            get;
            set;
        }

        public static string FileLogStatus
        {
            get;
            set;
        }

        public static string DBLogStatus
        {
            get;
            set;
        }

        public static string LogFilePath
        {
            get;
            set;
        }

        public static string LogDBConnectionString
        {
            get;
            set;
        }

        static LogHelper()
        {
            FileLogStatus = String.Empty;
            EventLogStatus = String.Empty;
            DBLogStatus = String.Empty;
        }

        private static void Initialize()
        {
            try
            {
            }
            catch { }
        }

        public static void AsyncLogWrite(string message, MessageType messageType, bool PassThrough)
        {
        }

        public static void AsyncAuditLogWrite(string message, MessageType messageType)
        {
        }

        internal static void Write(string message, MessageType messageType)
        {
            Initialize();
        }
    }
}