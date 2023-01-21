namespace LoggingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LogProcessor logger = new InfoLogProcessor(new DebugLogProcessor(new ErrorLogProcessor(null)));
            logger.Log(LogProcessor.INFO, "It is info message");
            logger.Log(LogProcessor.DEBUG, "It is DEBUG message");
            logger.Log(LogProcessor.ERROR, "It is ERROR message");

        }
    }
}