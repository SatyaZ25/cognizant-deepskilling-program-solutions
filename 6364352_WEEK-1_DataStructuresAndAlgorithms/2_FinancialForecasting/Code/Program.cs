class Program
{
    static void Main()
    {
        var appleStock = new StockMarket("AAPL", 150.00m);
        
        var iphoneApp = new MobileApp("iPhone Tracker");
        var androidApp = new MobileApp("Android Tracker");
        var webDashboard = new WebApp("Web Dashboard");
        
        appleStock.RegisterObserver(iphoneApp);
        appleStock.RegisterObserver(androidApp);
        appleStock.RegisterObserver(webDashboard);
        
        // Initial price notification
        Console.WriteLine("Initial stock price:");
        appleStock.NotifyObservers();
        
        // Price change
        Console.WriteLine("\nPrice increases to $155.75:");
        appleStock.SetPrice(155.75m);
        
        // Remove one observer
        Console.WriteLine("\nRemoving Android tracker:");
        appleStock.RemoveObserver(androidApp);
        
        // Another price change
        Console.WriteLine("\nPrice drops to $152.50:");
        appleStock.SetPrice(152.50m);
    }
}
