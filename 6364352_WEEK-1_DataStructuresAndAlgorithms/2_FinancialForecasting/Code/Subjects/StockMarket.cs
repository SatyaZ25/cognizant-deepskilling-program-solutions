public class StockMarket : IStock
{
    private readonly List<IObserver> _observers = new();
    private string _stockSymbol;
    private decimal _price;

    public StockMarket(string stockSymbol, decimal initialPrice)
    {
        _stockSymbol = stockSymbol;
        _price = initialPrice;
    }

    public void SetPrice(decimal newPrice)
    {
        if (_price != newPrice)
        {
            _price = newPrice;
            NotifyObservers();
        }
    }

    public void RegisterObserver(IObserver observer) => _observers.Add(observer);
    public void RemoveObserver(IObserver observer) => _observers.Remove(observer);
    
    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_stockSymbol, _price);
        }
    }
}
