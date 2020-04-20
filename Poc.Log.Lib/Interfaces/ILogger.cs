using Poc.Log.Lib.Arguments;

namespace Poc.Log.Lib.Interfaces
{
    interface ILogger
    {
        void Gravar(LoggerArgs loggerArgs);
    }
}
