class Program
{
    static void Main()
    {

        Console.WriteLine("Select search type (1=Simple, 2=Advanced, 3=Filtered):");
        var input = Console.ReadLine();

        SearchAlgorithmFactory factory = input switch
        {
            "1" => new SimpleSearchFactory(),
            "2" => new AdvancedSearchFactory(),
            "3" => new FilteredSearchFactory(),
            _ => throw new ArgumentException("Invalid search type")
        };

        ISearchAlgorithm searchAlgorithm = factory.CreateSearchAlgorithm();
        
        Console.WriteLine("Enter search query:");
        var query = Console.ReadLine();
        var results = searchAlgorithm.ExecuteSearch(query);

        Console.WriteLine("\nSearch Results:");
        foreach (var result in results)
        {
            Console.WriteLine($"- {result}");
        }
    }
}

