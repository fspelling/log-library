using Poc.Log.Lib.Enums;
using System;
using System.Collections.Generic;

namespace Poc.Log.Lib.Arguments
{
    /// <summary>
    /// Representa entrada dos argumentos do log
    /// </summary>
    public class LoggerArgs
    {
        /// <summary>
        /// Tipo do log
        /// </summary>
        public LogType LogType { get; }

        /// <summary>
        /// Mensagem do log
        /// </summary>
        public string Message { get; }

        /// <summary>
        /// Data que iniciou o processamento
        /// </summary>
        public DateTime? DateStart { get; }

        /// <summary>
        /// Data que finalizou o processamento
        /// </summary>
        public DateTime? DateFinish { get; }

        /// <summary>
        /// Excessao gerado para o log
        /// </summary>
        public Exception Exception { get; }

        /// <summary>
        /// Nome do namespace do sistema que esta chamando o log
        /// </summary>
        public string Source { get; }

        /// <summary>
        /// Lista dos objetos especificos para cada sistema que esteja consumindo
        /// </summary>
        public Dictionary<string, object> Objects { get; }

        /// <summary>
        /// Inicializa a intancia da classe Poc.Log.Lib.Arguments.LoggerArgs
        /// </summary>
        /// <param name="logType">Tipo do log</param>
        /// <param name="message">Mensagem do log</param>
        /// <param name="dateStart">Data que iniciou o processamento</param>
        /// <param name="dateFinish">Data que finalizou o processamento</param>
        /// <param name="exception">Excessao gerado para o log</param>
        /// <param name="source">Nome do namespace do sistema que esta chamando o log</param>
        /// <param name="objects">Lista dos objetos especificos para cada sistema que esteja consumindo</param>
        public LoggerArgs(LogType logType, string message, DateTime? dateStart, DateTime? dateFinish, Exception exception = null, string source = "", Dictionary<string, object> objects = null)
        {
            LogType = logType;
            Message = message;
            DateStart = dateStart;
            DateFinish = dateFinish;
            Objects = objects;
            Exception = exception;
            Source = source;
        }
    }
}
