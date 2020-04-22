using Poc.Log.Lib.Enums;
using Poc.Log.Lib.Arguments;
using System;

namespace Poc.Log.Lib.Targets.Base
{
    /// <summary>
    /// Super classe que representa os logs de cada target gerado
    /// </summary>
    public class Logger
    {
        /// <summary>
        /// Atributo que representa o log do framework NLOG
        /// </summary>
        protected NLog.Logger _log;

        /// <summary>
        /// Inicializa a intancia da classe Poc.Log.Lib.Targets.Base.Logger
        /// </summary>
        public Logger() => _log = LogManager.GetLogger();

        /// <summary>
        /// Retorna um novo objeto do tipo NLOG.LogEventInfo, de acordo com as informacoes passadas em seu parametro
        /// </summary>
        /// <param name="loggerArgs">Objeto que representa os dados ha serem gravados no log</param>
        /// <returns>Objeto do tipo NLOG.LogEventInfo</returns>
        protected NLog.LogEventInfo GerarLogEventInfo(in LoggerArgs loggerArgs)
        {
            var logEventInfo = CarregarLevelLog(loggerArgs.LogType, loggerArgs.Message);

            logEventInfo.Exception = loggerArgs.exception;

            logEventInfo.Properties["DateStart"] = loggerArgs.DateStart.HasValue ? 
                loggerArgs.DateStart.Value.ToString("yyyy-MM-dd HH:mm:ss.fff") :
                null;

            logEventInfo.Properties["DateFinish"] = loggerArgs.DateFinish.HasValue ? 
                loggerArgs.DateFinish.Value.ToString("yyyy-MM-dd HH:mm:ss.fff") :
                null;

            foreach (var item in loggerArgs.objects)
            {
                var value = (item.Value is DateTime valueDateTime) ? valueDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff") : 
                    item.Value.ToString();

                logEventInfo.Properties[item.Key] = value;
            }

            return logEventInfo;
        }

        #region Metodos_Auxiliares

        private NLog.LogEventInfo CarregarLevelLog(in LogType logType, in string message)
        {
            NLog.LogEventInfo logEventInfo;

            switch (logType)
            {
                case LogType.Info:
                    logEventInfo = new NLog.LogEventInfo(NLog.LogLevel.Info, "", message);
                    break;
                case LogType.Debug:
                    logEventInfo = new NLog.LogEventInfo(NLog.LogLevel.Debug, "", message);
                    break;
                case LogType.Error:
                    logEventInfo = new NLog.LogEventInfo(NLog.LogLevel.Error, "", message);
                    break;
                case LogType.Trace:
                    logEventInfo = new NLog.LogEventInfo(NLog.LogLevel.Trace, "", message);
                    break;
                default:
                    logEventInfo = new NLog.LogEventInfo();
                    break;
            }

            return logEventInfo;
        }

        #endregion
    }
}