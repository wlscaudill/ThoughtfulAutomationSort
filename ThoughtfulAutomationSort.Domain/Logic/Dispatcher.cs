namespace ThoughtfulAutomationSort.Domain
{
    using System;

    public class Dispatcher : IDispatcher
    {
        public SortResult Sort(Evaluation evaluation)
        {
            var stack = SelectStack(evaluation);
            return new SortResult(stack);
        }

        private SortStack SelectStack(Evaluation evaluation)
        {
            if (evaluation.IsBulky && evaluation.IsHeavy)
            {
                return SortStack.Rejected;
            }

            if (evaluation.IsBulky || evaluation.IsHeavy)
            {
                return SortStack.Special;
            }

            if (!evaluation.IsBulky && !evaluation.IsHeavy)
            {
                return SortStack.Standard;
            }

            // Would create a ToString() on object without time contraint so that the entire set would be logged since encoutering this would be a result of something introduced most likely.
            throw new InvalidOperationException($"Invalid scenario encountered for evaluation bulky: {evaluation.IsBulky}, heavy: {evaluation.IsHeavy}");
        }
    }
}
