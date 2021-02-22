namespace GoltaraSolutions.Common.Infra.Log
{
    public static class Logger
    {
        private static ILogger _log;
        public static ILogger Log
        {
            get { return _log; }
            set { _log = value; }
        }
    }
}
