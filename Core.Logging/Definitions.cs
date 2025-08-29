#region Namespace Declaration

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#endregion

namespace Core.Logging
{
    public enum LogEventPriorityType
    {
        Critical,
        Error,
        Warning,
        Informational
    }

    /// <summary>
    /// DataProvider enumeration
    /// </summary>
    public enum DataProvider
    {
        Oracle, SqlServer, OleDb, Odbc
    }

    /// <summary>
    /// Message Type enumerator
    /// </summary>
    public enum MessageType
    {
        /// <value>Informational message</value>
        Informational = 1,

        /// <value>Warning message</value>
        Warning = 2,

        /// <value>Error message</value>
        Error = 3,

        /// <value>Critical message</value>
        Critical = 4
    }

    public enum LogTarget
    {
        /// <value>Event Logger</value>
        Event = 1,

        /// <value>File Logger</value>
        File = 2,

        /// <value>DB Logger</value>
        Database = 3,

        /// <value>Sys Logger</value>
        SysLog = 4
    }
}