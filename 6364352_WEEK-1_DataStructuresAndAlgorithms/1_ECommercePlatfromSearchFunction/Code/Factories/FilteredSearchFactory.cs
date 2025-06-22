public class FilteredSearchFactory : SearchAlgorithmFactory
{
    public override ISearchAlgorithm CreateSearchAlgorithm() => new FilteredSearch();
}
