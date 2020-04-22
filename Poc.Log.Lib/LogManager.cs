using NLog.Web;

namespace Poc.Log.Lib
{
    internal static class LogManager
    {
        private static NLog.Logger _logger;

        internal static NLog.Logger GetLogger()
        {
            if (_logger == null) _logger = NLogBuilder.ConfigureNLog("NLog.config").GetCurrentClassLogger();
            return _logger;
        }
    }
}
