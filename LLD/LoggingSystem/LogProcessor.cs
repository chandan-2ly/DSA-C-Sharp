namespace LoggingSystem
{
    public abstract class LogProcessor
    {
        public static int INFO = 1;
        public static int DEBUG = 2;
        public static int ERROR = 3;
        LogProcessor nextLogProcessor;

        public LogProcessor(LogProcessor next)
        {
            nextLogProcessor = next;
        }

        public virtual void Log(int logLevel, string message)
        {
            if(nextLogProcessor != null)
            {
                nextLogProcessor.Log(logLevel, message);
            }
        }
    }
}
