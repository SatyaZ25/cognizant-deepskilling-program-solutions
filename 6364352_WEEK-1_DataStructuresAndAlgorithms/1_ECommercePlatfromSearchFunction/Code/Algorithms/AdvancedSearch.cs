public class AdvancedSearch : ISearchAlgorithm
{
    public List<string> ExecuteSearch(string query)
    {
        return new List<string> { 
            $"{query} - Premium Edition", 
            $"{query} - Professional Bundle",
            $"{query} - Limited Edition"
        };
    }
}
