namespace ThoughtfulAutomationSort.Domain
{
    public class Evaluation
    {
        public Evaluation(bool isBulky, bool isHeavy)
        {
            // Would probably take the time to create a flags enum without time constraint
            this.IsBulky = isBulky;
            this.IsHeavy = isHeavy;
        }

        public bool IsBulky { get; private set; }
        public bool IsHeavy { get; private set; }
    }
}
