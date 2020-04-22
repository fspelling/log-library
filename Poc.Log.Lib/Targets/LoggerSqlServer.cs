﻿using Poc.Log.Lib.Arguments;

namespace Poc.Log.Lib.Targets
{
    /// <summary>
    /// Classe que representa os logs do banco de dados sql server
    /// </summary>
    public class LoggerSqlServer : Base.Logger, Interfaces.ILogger
    {
        /// <summary>
        /// Grava as informacoes no log
        /// </summary>
        /// <param name="loggerArgs">Objeto que representa os dados ha serem gravados no log</param>
        public virtual void Gravar(LoggerArgs loggerArgs) => _log.Log(GerarLogEventInfo(loggerArgs));
    }
}
