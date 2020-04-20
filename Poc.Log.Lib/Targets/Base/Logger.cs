using Poc.Log.Lib.Enums;
using System.Collections.Generic;

namespace Poc.Log.Lib.Targets.Base
{
    public class Logger
    {
        protected NLog.Logger _log;

        public Logger() => _log = LogManager.GetLogger();

        protected NLog.LogEventInfo GerarLogEventInfo(LogType logType, string message, Dictionary<string, object> objects) =>
            new NLog.LogEventInfo();
    }
}
