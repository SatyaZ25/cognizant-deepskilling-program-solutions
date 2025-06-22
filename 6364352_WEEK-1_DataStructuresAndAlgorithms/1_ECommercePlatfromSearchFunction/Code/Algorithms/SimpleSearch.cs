public class SimpleSearch : ISearchAlgorithm
{
    public List<string> ExecuteSearch(string query)
    {
        return new List<string> { 
            $"Product A ({query})", 
            $"Product B ({query})" 
        };
    }
}
