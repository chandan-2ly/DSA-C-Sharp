namespace LoggingSystem
{
    public class ErrorLogProcessor : LogProcessor
    {
        public ErrorLogProcessor(LogProcessor next) : base(next)
        {
        }

        public override void Log(int logLevel, string message)
        {
            if(logLevel == ERROR)
            {
                Console.WriteLine("ERROR: " + message);
            }
            else
            {
                base.Log(logLevel, message);
            }
        }
    }
}
