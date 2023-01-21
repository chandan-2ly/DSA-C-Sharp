namespace LoggingSystem
{
    public class DebugLogProcessor : LogProcessor
    {
        public DebugLogProcessor(LogProcessor next) : base(next)
        {
        }

        public override void Log(int logLevel, string message)
        {
            if(logLevel == DEBUG)
            {
                Console.WriteLine("DEBUG: " + message);
            }
            else
            {
                base.Log(logLevel, message);
            }
        }
    }
}
