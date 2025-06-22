public class AdvancedSearchFactory : SearchAlgorithmFactory
{
    public override ISearchAlgorithm CreateSearchAlgorithm() => new AdvancedSearch();
}
