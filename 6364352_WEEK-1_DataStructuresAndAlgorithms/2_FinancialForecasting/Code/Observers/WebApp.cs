public class WebApp : IObserver
{
    private readonly string _name;
    
    public WebApp(string name) => _name = name;

    public void Update(string stockSymbol, decimal price)
    {
        Console.WriteLine($"[Web App: {_name}] {stockSymbol} price changed: ${price}");
    }
}
