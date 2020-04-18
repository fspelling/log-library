using Poc.Log.Lib.Enums;
using System.Collections.Generic;

namespace Poc.Log.Lib.Interfaces
{
    interface ILogger
    {
        void Gravar(LogType logType, string message, Dictionary<string, object> objects);
    }
}
