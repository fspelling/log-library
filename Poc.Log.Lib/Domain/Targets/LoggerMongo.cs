using Poc.Log.Lib.Domain.Interfaces;
using Poc.Log.Lib.Entity;

namespace Poc.Log.Lib.Domain.Targets
{
    /// <summary>
    /// Classe que representa os logs do banco de dados nsql mongodb
    /// </summary>
    public class LoggerMongo : Base.Logger, ILogger
    {
        /// <summary>
        /// Inicializa a intancia da classe Poc.Log.Lib.Domain.Targets.LoggerMongo
        /// </summary>
        public LoggerMongo() { }

        /// <summary>
        /// Grava as informacoes no log
        /// </summary>
        /// <param name="loggerArgs">Objeto que representa os dados ha serem gravados no log</param>
        public virtual void Save(LoggerArgs loggerArgs) => _log.Log(GetLogEventInfo(loggerArgs));
    }
}
