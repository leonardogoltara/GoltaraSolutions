using System;
using System.Runtime.CompilerServices;

namespace GoltaraSolutions.Common.Infra.Log
{
    public interface ILogger
    {
        void Inicialize(string loggerName);
        void Debug(string message, [CallerMemberName]string memberName = "");
        void Info(string message, [CallerMemberName]string memberName = "");
        void Warn(string message, [CallerMemberName]string memberName = "");
        void Warn(Exception ex, [CallerMemberName]string memberName = "");
        void Error(string message, [CallerMemberName]string memberName = "");
        void Error(Exception ex, [CallerMemberName]string memberName = "");
        void Fatal(string message, [CallerMemberName]string memberName = "");
        void Fatal(Exception ex, [CallerMemberName]string memberName = "");
    }
}
