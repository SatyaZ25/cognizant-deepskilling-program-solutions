public class SimpleSearchFactory : SearchAlgorithmFactory
{
    public override ISearchAlgorithm CreateSearchAlgorithm() => new SimpleSearch();
}
