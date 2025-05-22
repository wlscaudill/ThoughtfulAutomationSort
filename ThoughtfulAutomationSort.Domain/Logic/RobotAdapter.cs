namespace ThoughtfulAutomationSort.Domain
{
    public class RobotAdapter
    {
        // Could pass these in if different situations had different needs.
        private static IEvaluator Evaluator = new Evaluator();
        private static IDispatcher Dispatcher = new Dispatcher();

        public static string sort(int width, int height, int length, int mass)
        {
            var package = new Package(width, height, length, mass);
            var evaluation = Evaluator.Evaluate(package);
            var sortResult = Dispatcher.Sort(evaluation);
            var result = sortResult.SortStack.ToString();
            return result;
        }
    }
}
