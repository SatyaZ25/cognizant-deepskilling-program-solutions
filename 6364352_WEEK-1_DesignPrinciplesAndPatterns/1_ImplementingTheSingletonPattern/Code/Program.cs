class Program
{
    static void Main()
    {
        Logger logger1 = Logger.GetInstance();
        Logger logger2 = Logger.GetInstance();
        
        Console.WriteLine($"Same instance? {ReferenceEquals(logger1, logger2)}");
        
        logger1.Log("Test message from logger1");
        logger2.Log("Test message from logger2");
    }
}