namespace ThoughtfulAutomationSort.Domain.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DispatcherTest
    {
        [TestMethod]
        public void Sort___HeavyAndBulkyPackage___Rejected()
        {
            // Arrange
            var package = new Package(1, 1, Evaluator.BULKY_DIMENSION, Evaluator.HEAVY_MASS);

            // Act
            var evaluation = new Evaluator().Evaluate(package);
            var sortResult = new Dispatcher().Sort(evaluation);

            // Assert
            Assert.AreEqual(true, evaluation.IsBulky);
            Assert.AreEqual(true, evaluation.IsHeavy);
            Assert.AreEqual(SortStack.Rejected, sortResult.SortStack);
        }

        [TestMethod]
        public void Sort___HeavyNotBulkyPackage___Special()
        {
            // Arrange
            var package = new Package(1, 1, Evaluator.BULKY_DIMENSION - 1, Evaluator.HEAVY_MASS);

            // Act
            var evaluation = new Evaluator().Evaluate(package);
            var sortResult = new Dispatcher().Sort(evaluation);

            // Assert
            Assert.AreEqual(false, evaluation.IsBulky);
            Assert.AreEqual(true, evaluation.IsHeavy);
            Assert.AreEqual(SortStack.Special, sortResult.SortStack);
        }

        [TestMethod]
        public void Sort___BulkyNotHeavyPackage___Special()
        {
            // Arrange
            var package = new Package(1, 1, Evaluator.BULKY_DIMENSION, Evaluator.HEAVY_MASS - 1);

            // Act
            var evaluation = new Evaluator().Evaluate(package);
            var sortResult = new Dispatcher().Sort(evaluation);

            // Assert
            Assert.AreEqual(true, evaluation.IsBulky);
            Assert.AreEqual(false, evaluation.IsHeavy);
            Assert.AreEqual(SortStack.Special, sortResult.SortStack);
        }

        [TestMethod]
        public void Sort___NotBulkyNotHeavyPackage___Standard()
        {
            // Arrange
            var package = new Package(1, 1, Evaluator.BULKY_DIMENSION - 1, Evaluator.HEAVY_MASS - 1);

            // Act
            var evaluation = new Evaluator().Evaluate(package);
            var sortResult = new Dispatcher().Sort(evaluation);

            // Assert
            Assert.AreEqual(false, evaluation.IsBulky);
            Assert.AreEqual(false, evaluation.IsHeavy);
            Assert.AreEqual(SortStack.Standard, sortResult.SortStack);
        }
    }
}
