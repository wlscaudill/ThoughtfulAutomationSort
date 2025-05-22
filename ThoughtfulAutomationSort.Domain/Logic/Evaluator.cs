namespace ThoughtfulAutomationSort.Domain
{
    public class Evaluator : IEvaluator
    {
        // Could pass these in if different situations had different values.
        public const int BULKY_VOLUME = 1000000;
        public const int BULKY_DIMENSION = 150;
        public const int HEAVY_MASS = 20;

        public Evaluation Evaluate(Package package)
        {
            var isBulky = this.CheckIsBulky(package);
            var isHeavy = this.CheckIsHeavy(package);
            return new Evaluation(isBulky, isHeavy);
        }

        private bool CheckIsBulky(Package package)
        {
            return package.Volume >= BULKY_VOLUME || package.Width >= BULKY_DIMENSION || package.Height >= BULKY_DIMENSION || package.Length >= BULKY_DIMENSION;
        }

        private bool CheckIsHeavy(Package package)
        {
            return package.Mass >= HEAVY_MASS;
        }
    }
}
