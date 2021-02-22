using log4net;
using log4net.Config;
using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace GoltaraSolutions.Common.Infra.Log.Log4Net
{
    public class Log4NetLogger : ILogger
    {
        private ILog log = null;

        public Log4NetLogger()
        {
            XmlConfigurator.Configure(new FileInfo(AppDomain.CurrentDomain.BaseDirectory + "\\log4netConfig.xml"));
            log = LogManager.GetLogger("WARN");
        }

        public void Inicialize(string loggerName)
        {
            log = LogManager.GetLogger(loggerName);
        }

        private string BuildLogMessage(string logger, string message)
        {
            return $@"{logger} >>> {message}";
        }
        private string BuildLogMessage(string logger, Exception ex)
        {
            return $@"{logger} >>> {ex.Message} >>> {ex.StackTrace.ToString()}";
        }
        public void Debug(string message, [CallerMemberName] string memberName = "")
        {
            log.Debug(BuildLogMessage(memberName, message));
        }

        public void Error(string message, [CallerMemberName] string memberName = "")
        {
            log.Error(BuildLogMessage(memberName, message));
        }

        public void Error(Exception ex, [CallerMemberName] string memberName = "")
        {
            log.Error(BuildLogMessage(memberName, ex));
        }

        public void Fatal(string message, [CallerMemberName] string memberName = "")
        {
            log.Fatal(BuildLogMessage(memberName, message));
        }

        public void Fatal(Exception ex, [CallerMemberName] string memberName = "")
        {
            log.Fatal(BuildLogMessage(memberName, ex));
        }

        public void Info(string message, [CallerMemberName] string memberName = "")
        {
            log.Info(BuildLogMessage(memberName, message));
        }

        public void Warn(string message, [CallerMemberName] string memberName = "")
        {
            log.Warn(BuildLogMessage(memberName, message));
        }

        public void Warn(Exception ex, [CallerMemberName] string memberName = "")
        {
            log.Warn(BuildLogMessage(memberName, ex));
        }
    }
}
