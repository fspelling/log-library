using Poc.Log.Lib.Enums;
using System;
using System.Collections.Generic;

namespace Poc.Log.Lib.Arguments
{
    public class LoggerArgs
    {
        public LogType LogType { get; }
        public string Message { get; }
        public DateTime? DateStart { get; }
        public DateTime? DateFinish { get; }
        public Exception exception { get; }
        public Dictionary<string, object> objects { get; }

        public LoggerArgs(LogType logType, string message, DateTime? dateStart, DateTime? dateFinish, Exception exception = null, Dictionary<string, object> objects = null)
        {
            LogType = logType;
            Message = message;
            DateStart = dateStart;
            DateFinish = dateFinish;
            this.objects = objects;
        }
    }
}
