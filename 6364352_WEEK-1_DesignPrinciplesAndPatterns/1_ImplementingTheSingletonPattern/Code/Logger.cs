public sealed class Logger
{
    private static readonly Logger _instance = new Logger();
    
    private Logger() { }
    public static Logger GetInstance() => _instance;
    public void Log(string message)
    {
        Console.WriteLine($"[{DateTime.UtcNow:u}] {message}");
    }
}