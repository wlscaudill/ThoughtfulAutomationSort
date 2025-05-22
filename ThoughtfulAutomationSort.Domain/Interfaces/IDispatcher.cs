namespace ThoughtfulAutomationSort.Domain
{
    public interface IDispatcher
    {
        SortResult Sort(Evaluation evaluation);
    }
}
