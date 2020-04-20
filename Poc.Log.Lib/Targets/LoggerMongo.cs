﻿using Poc.Log.Lib.Arguments;

namespace Poc.Log.Lib.Targets
{
    public class LoggerMongo : Base.Logger, Interfaces.ILogger
    {
        public virtual void Gravar(LoggerArgs loggerArgs) => _log.Log(GerarLogEventInfo(loggerArgs));
    }
}
