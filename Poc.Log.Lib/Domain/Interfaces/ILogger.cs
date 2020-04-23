using Poc.Log.Lib.Entity;

namespace Poc.Log.Lib.Domain.Interfaces
{
    /// <summary>
    /// Interface de log que sera implementada em cada target
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Grava as informacoes no log
        /// </summary>
        /// <param name="loggerArgs">Objeto que representa os dados a serem gravados no log</param>
        void Save(LoggerArgs loggerArgs);
    }
}
