namespace LoggingSystem
{
    public class InfoLogProcessor : LogProcessor
    {
        public InfoLogProcessor(LogProcessor next) : base(next)
        {
        }

        public override void Log(int logLevel, string message)
        {
            if(logLevel == INFO)
            {
                Console.WriteLine("INFO: "+message);
            }
            else
            {
                base.Log(logLevel, message);
            }
        }
    }
}
