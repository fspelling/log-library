using Poc.Log.Lib.Enums;
using System.Collections.Generic;

namespace Poc.Log.Lib.Targets
{
    public class LoggerMongo : Base.Logger, Interfaces.ILogger
    {
        public virtual void Gravar(LogType logType, string message, Dictionary<string, object> objects) =>
            _log.Log(GerarLogEventInfo(logType, message, objects));
    }
}
