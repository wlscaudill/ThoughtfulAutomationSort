namespace ThoughtfulAutomationSort.Domain.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class PackageTest
    {
        [TestMethod]
        public void ConstructPackage_ZeroWidth_ThrowsArgumentException()
        {
            // Arrange
            Action action = () => new Package(0, 1, 1, 1);

            // Act
            var exception = Record.Exception(action);

            // Assert
            Assert.AreEqual(typeof(ArgumentException), exception.GetType());
            var argumentException = (ArgumentException)exception;
            Assert.IsTrue(argumentException.Message.StartsWith(Package.INVALID_VALUE_MESSAGE));
            Assert.AreEqual(nameof(Package.Width).ToLower(), argumentException.ParamName);
        }

        [TestMethod]
        public void ConstructPackage_ZeroHeight_ThrowsArgumentException()
        {
            // Arrange
            Action action = () => new Package(1, 0, 1, 1);

            // Act
            var exception = Record.Exception(action);

            // Assert
            Assert.AreEqual(typeof(ArgumentException), exception.GetType());
            var argumentException = (ArgumentException)exception;
            Assert.IsTrue(argumentException.Message.StartsWith(Package.INVALID_VALUE_MESSAGE));
            Assert.AreEqual(nameof(Package.Height).ToLower(), argumentException.ParamName);
        }

        [TestMethod]
        public void ConstructPackage_ZeroLength_Throws()
        {
            // Arrange
            Action action = () => new Package(1, 1, 0, 1);

            // Act
            var exception = Record.Exception(action);

            // Assert
            Assert.AreEqual(typeof(ArgumentException), exception.GetType());
            var argumentException = (ArgumentException)exception;
            Assert.IsTrue(argumentException.Message.StartsWith(Package.INVALID_VALUE_MESSAGE));
            Assert.AreEqual(nameof(Package.Length).ToLower(), argumentException.ParamName);
        }

        [TestMethod]
        public void ConstructPackage_ZeroMass_Throws()
        {
            // Arrange
            Action action = () => new Package(1, 1, 1, 0);

            // Act
            var exception = Record.Exception(action);

            // Assert
            Assert.AreEqual(typeof(ArgumentException), exception.GetType());
            var argumentException = (ArgumentException)exception;
            Assert.IsTrue(argumentException.Message.StartsWith(Package.INVALID_VALUE_MESSAGE));
            Assert.AreEqual(nameof(Package.Mass).ToLower(), argumentException.ParamName);
        }

        [TestMethod]
        public void ConstructPackage_NegativeWidth_ThrowsArgumentException()
        {
            // Arrange
            Action action = () => new Package(-1, 1, 1, 1);

            // Act
            var exception = Record.Exception(action);

            // Assert
            Assert.AreEqual(typeof(ArgumentException), exception.GetType());
            var argumentException = (ArgumentException)exception;
            Assert.IsTrue(argumentException.Message.StartsWith(Package.INVALID_VALUE_MESSAGE));
            Assert.AreEqual(nameof(Package.Width).ToLower(), argumentException.ParamName);
        }

        [TestMethod]
        public void ConstructPackage_NegativeHeight_ThrowsArgumentException()
        {
            // Arrange
            Action action = () => new Package(1, -1, 1, 1);

            // Act
            var exception = Record.Exception(action);

            // Assert
            Assert.AreEqual(typeof(ArgumentException), exception.GetType());
            var argumentException = (ArgumentException)exception;
            Assert.IsTrue(argumentException.Message.StartsWith(Package.INVALID_VALUE_MESSAGE));
            Assert.AreEqual(nameof(Package.Height).ToLower(), argumentException.ParamName);
        }

        [TestMethod]
        public void ConstructPackage_NegativeLength_Throws()
        {
            // Arrange
            Action action = () => new Package(1, 1, -1, 1);

            // Act
            var exception = Record.Exception(action);

            // Assert
            Assert.AreEqual(typeof(ArgumentException), exception.GetType());
            var argumentException = (ArgumentException)exception;
            Assert.IsTrue(argumentException.Message.StartsWith(Package.INVALID_VALUE_MESSAGE));
            Assert.AreEqual(nameof(Package.Length).ToLower(), argumentException.ParamName);
        }

        [TestMethod]
        public void ConstructPackage_NegativeMass_Throws()
        {
            // Arrange
            Action action = () => new Package(1, 1, 1, -1);

            // Act
            var exception = Record.Exception(action);

            // Assert
            Assert.AreEqual(typeof(ArgumentException), exception.GetType());
            var argumentException = (ArgumentException)exception;
            Assert.IsTrue(argumentException.Message.StartsWith(Package.INVALID_VALUE_MESSAGE));
            Assert.AreEqual(nameof(Package.Mass).ToLower(), argumentException.ParamName);
        }


        [TestMethod]
        public void Volume_ValidPackage_ReturnsCorretVolume()
        {
            // Arrange
            var width = 2;
            var height = 3;
            var length = 4;
            var package = new Package(width, height, length, 1);
            var expectedVolume = width * height * length;

            // Act
            var actualVolume = package.Volume;

            // Assert
            Assert.AreEqual(expectedVolume, actualVolume);
        }
    }
}
