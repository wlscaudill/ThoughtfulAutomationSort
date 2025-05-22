namespace ThoughtfulAutomationSort.Domain.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class RobotAdapterTest
    {
        [TestMethod]
        public void Sort___WithInputs___RunsExpectedLogic()
        {
            // Arrange
            var packageStandard = new Package(1, 1, 1, 1);
            var packageSpecialBulky = new Package(1, 1, Evaluator.BULKY_DIMENSION, 1);
            var packageSpecialHeavy = new Package(1, 1, 1, Evaluator.HEAVY_MASS);
            var packageRejected = new Package(1, 1, Evaluator.BULKY_DIMENSION, Evaluator.HEAVY_MASS);

            // Act
            var resultRobotStandard = RobotAdapter.sort(packageStandard.Width, packageStandard.Height, packageStandard.Length, packageStandard.Mass);
            var resultRobotSpecialBulky = RobotAdapter.sort(packageSpecialBulky.Width, packageSpecialBulky.Height, packageSpecialBulky.Length, packageSpecialBulky.Mass);
            var resultRobotSpecialHeavy = RobotAdapter.sort(packageSpecialHeavy.Width, packageSpecialHeavy.Height, packageSpecialHeavy.Length, packageSpecialHeavy.Mass);
            var resultRobotRejected = RobotAdapter.sort(packageRejected.Width, packageRejected.Height, packageRejected.Length, packageRejected.Mass);

            // Assert
            Assert.AreEqual(SortStack.Standard.ToString(), resultRobotStandard);
            Assert.AreEqual(SortStack.Special.ToString(), resultRobotSpecialBulky);
            Assert.AreEqual(SortStack.Special.ToString(), resultRobotSpecialHeavy);
            Assert.AreEqual(SortStack.Rejected.ToString(), resultRobotRejected);
        }
    }
}
