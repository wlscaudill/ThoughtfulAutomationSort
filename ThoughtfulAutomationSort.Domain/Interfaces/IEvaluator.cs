namespace ThoughtfulAutomationSort.Domain
{
    public interface IEvaluator
    {
        Evaluation Evaluate(Package package);
    }
}
