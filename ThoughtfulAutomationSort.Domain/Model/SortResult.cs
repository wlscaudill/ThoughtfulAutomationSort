namespace ThoughtfulAutomationSort.Domain
{
    public class SortResult
    {
        public SortResult(SortStack sortStack)
        {
            this.SortStack = sortStack;
        }

        public SortStack SortStack { get; private set; }
    }
}
