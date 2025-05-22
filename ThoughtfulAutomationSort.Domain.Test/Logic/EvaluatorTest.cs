namespace ThoughtfulAutomationSort.Domain.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class EvaluatorTest
    {
        [TestMethod]
        public void Evaluate___StandardPackage___EvaluatesWithoutFlags()
        {
            // Arrange
            var package = new Package(1, 1, Evaluator.BULKY_DIMENSION - 1, Evaluator.HEAVY_MASS - 1);

            // Act
            var evaluation = new Evaluator().Evaluate(package);

            // Assert
            Assert.AreEqual(false, evaluation.IsBulky);
            Assert.AreEqual(false, evaluation.IsHeavy);
        }

        [TestMethod]
        public void Evaluate___ExactlyHeavyPackage___EvaluatesWithHeavyFlag()
        {
            // Arrange
            var package = new Package(2, 2, 2, Evaluator.HEAVY_MASS);

            // Act
            var evaluation = new Evaluator().Evaluate(package);

            // Assert
            Assert.AreEqual(false, evaluation.IsBulky);
            Assert.AreEqual(true, evaluation.IsHeavy);
        }

        [TestMethod]
        public void Evaluate___HeavyPackage___EvaluatesWithHeavyFlag()
        {
            // Arrange
            var package = new Package(2, 2, 2, Evaluator.HEAVY_MASS + 1);

            // Act
            var evaluation = new Evaluator().Evaluate(package);

            // Assert
            Assert.AreEqual(false, evaluation.IsBulky);
            Assert.AreEqual(true, evaluation.IsHeavy);
        }

        [TestMethod]
        public void Evaluate___ExactlyBulkyVolumePackage___EvaluatesWithBulkyFlag()
        {
            // Arrange
            var package = new Package(100, 100, 100, Evaluator.HEAVY_MASS - 1);

            // Act
            var evaluation = new Evaluator().Evaluate(package);

            // Assert
            Assert.AreEqual(true, evaluation.IsBulky);
            Assert.AreEqual(false, evaluation.IsHeavy);
        }

        [TestMethod]
        public void Evaluate___BulkyVolumePackage___EvaluatesWithBulkyFlag()
        {
            // Arrange
            var package = new Package(101, 101, 101, Evaluator.HEAVY_MASS - 1);

            // Act
            var evaluation = new Evaluator().Evaluate(package);

            // Assert
            Assert.AreEqual(true, evaluation.IsBulky);
            Assert.AreEqual(false, evaluation.IsHeavy);
        }

        [TestMethod]
        public void Evaluate___ExactlyBulkyDimensionWidthPackage___EvaluatesWithBulkyFlag()
        {
            // Arrange
            var package = new Package(Evaluator.BULKY_DIMENSION, 1, 1, Evaluator.HEAVY_MASS - 1);

            // Act
            var evaluation = new Evaluator().Evaluate(package);

            // Assert
            Assert.AreEqual(true, evaluation.IsBulky);
            Assert.AreEqual(false, evaluation.IsHeavy);
        }

        [TestMethod]
        public void Evaluate___BulkyDimensionWidthPackage___EvaluatesWithBulkyFlag()
        {
            // Arrange
            var package = new Package(Evaluator.BULKY_DIMENSION + 1, 1, 1, Evaluator.HEAVY_MASS - 1);

            // Act
            var evaluation = new Evaluator().Evaluate(package);

            // Assert
            Assert.AreEqual(true, evaluation.IsBulky);
            Assert.AreEqual(false, evaluation.IsHeavy);
        }

        [TestMethod]
        public void Evaluate___ExactlyBulkyDimensionHeightPackage___EvaluatesWithBulkyFlag()
        {
            // Arrange
            var package = new Package(1, Evaluator.BULKY_DIMENSION, 1, Evaluator.HEAVY_MASS - 1);

            // Act
            var evaluation = new Evaluator().Evaluate(package);

            // Assert
            Assert.AreEqual(true, evaluation.IsBulky);
            Assert.AreEqual(false, evaluation.IsHeavy);
        }

        [TestMethod]
        public void Evaluate___BulkyDimensionHeightPackage___EvaluatesWithBulkyFlag()
        {
            // Arrange
            var package = new Package(1, Evaluator.BULKY_DIMENSION + 1, 1, Evaluator.HEAVY_MASS - 1);

            // Act
            var evaluation = new Evaluator().Evaluate(package);

            // Assert
            Assert.AreEqual(true, evaluation.IsBulky);
            Assert.AreEqual(false, evaluation.IsHeavy);
        }

        [TestMethod]
        public void Evaluate___ExactlyBulkyDimensionLengthPackage___EvaluatesWithBulkyFlag()
        {
            // Arrange
            var package = new Package(1, 1, Evaluator.BULKY_DIMENSION, Evaluator.HEAVY_MASS - 1);

            // Act
            var evaluation = new Evaluator().Evaluate(package);

            // Assert
            Assert.AreEqual(true, evaluation.IsBulky);
            Assert.AreEqual(false, evaluation.IsHeavy);
        }

        [TestMethod]
        public void Evaluate___BulkyDimensionLengthPackage___EvaluatesWithBulkyFlag()
        {
            // Arrange
            var package = new Package(1, 1, Evaluator.BULKY_DIMENSION + 1, Evaluator.HEAVY_MASS - 1);

            // Act
            var evaluation = new Evaluator().Evaluate(package);

            // Assert
            Assert.AreEqual(true, evaluation.IsBulky);
            Assert.AreEqual(false, evaluation.IsHeavy);
        }
    }
}
