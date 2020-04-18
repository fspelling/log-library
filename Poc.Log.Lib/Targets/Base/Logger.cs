using Poc.Log.Lib.Enums;
using System.Collections.Generic;

namespace Poc.Log.Lib.Targets.Base
{
    public class Logger : Interfaces.ILogger
    {
        protected NLog.Logger _log;

        public Logger()
        {
            _log = LogManager.GetLogger();
        }

        public virtual void Gravar(LogType logType, string message, Dictionary<string, object> objects) =>
            _log.Log(GerarLogEventInfo(logType, message, objects));

        private NLog.LogEventInfo GerarLogEventInfo(LogType logType, string message, Dictionary<string, object> objects) =>
            new NLog.LogEventInfo();
    }
}
