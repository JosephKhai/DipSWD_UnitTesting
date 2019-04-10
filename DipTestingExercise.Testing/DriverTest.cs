using System;
using NUnit.Framework;
using DipTestingExercises;
using DipTestingExercise.Testing.Mocking;

namespace DipTestingExercise.Testing
{
    [TestFixture]
    public class DriverTest
    {
        private Driver _driver;

        [SetUp]
        public void Setup()
        {
            _driver = new FakeDriver("Joseph", "Khai", "Male", "Probationary");
        }

        [Test]
        public void DriverConstructor_MethodIsCalled_CheckFnameLnameGenderLicence_AreCorrect()
        {
            // Arrange
            // Act
            // Assert

            Assert.That(_driver.getName().Equals("Joseph Khai"));
            Assert.That(_driver.getGender().Equals("Male"));
            Assert.That(_driver.getLicenceType().Equals("Probationary"));

        }

        [Test]
        public void DriverGetLicenceType_MethodIsCalled_ReturnTicketType()
        {
            // Arrange
            // Act
            // Assert
            Assert.That(_driver.getLicenceType().Equals("Probationary"));

        }
    }
}
