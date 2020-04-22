using Poc.Log.Lib.Arguments;

namespace Poc.Log.Lib.Interfaces
{
    /// <summary>
    /// Interface de log que sera implementada em cada target
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Grava as informacoes no log
        /// </summary>
        /// <param name="loggerArgs">Objeto que representa os dados ha serem gravados no log</param>
        void Gravar(LoggerArgs loggerArgs);
    }
}
