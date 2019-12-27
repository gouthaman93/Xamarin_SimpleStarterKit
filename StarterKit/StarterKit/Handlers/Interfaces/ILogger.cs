using System;
using System.Collections.Generic;
using System.Text;

namespace StarterKit.Handlers.Interfaces
{
    interface ILogger
    {
        void Trace(string msg);
        void Trace(Exception ex, string msg);

        void Debug(string msg);
        void Debug(Exception ex, string msg);

        void Info(string msg);
        void Info(Exception ex, string msg);

        void Warn(string msg);
        void Warn(Exception ex, string msg);

        void Error(string msg);
        void Error(Exception ex, string msg);
    }
}
