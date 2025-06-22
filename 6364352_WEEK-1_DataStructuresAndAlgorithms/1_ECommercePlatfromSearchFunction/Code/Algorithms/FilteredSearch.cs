public class FilteredSearch : ISearchAlgorithm
{
    public List<string> ExecuteSearch(string query)
    {
        return new List<string> { 
            $"{query} (Price: $49.99)", 
            $"{query} (Price: $79.99)",
            $"{query} (Price: $29.99)",
            $"{query} (Price: $129.99)"
        };
    }
}
