public class MobileApp : IObserver
{
    private readonly string _name;
    
    public MobileApp(string name) => _name = name;

    public void Update(string stockSymbol, decimal price)
    {
        Console.WriteLine($"[Mobile App: {_name}] {stockSymbol} price updated: ${price}");
    }
}
