namespace Core.Logging
{
    internal static class FileLogger
    {
        private static readonly object lockObj = new object();

        public static void Write(string fileName, string message, MessageType severity)
        {
            try
            {
                lock (lockObj)
                {
                    System.IO.StreamWriter file = new System.IO.StreamWriter(fileName, true);
                    file.WriteLine(message);
                    file.Close();
                }
            }
            catch
            {
            }
        }
    }
}