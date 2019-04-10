using System;
using NUnit.Framework;
using DipTestingExercises;
using DipTestingExercise.Testing.Mocking;

namespace DipTestingExercise.Testing
{
    [TestFixture]
    public class PassengerTest
    {
        private Passenger _passenger;

        [SetUp]
        public void Setup()
        {
            _passenger = new FakePassenger("Christy", "Manbawi", "Female", "Bus");

        }

        [Test]
        public void PassengerConstructor_MethodIsCalled_CheckFnameLnameGenderTicketType_AreCorrect()
        {
            // Arrange
            // Act
            // Assert

            Assert.That(_passenger.getName().Equals("Christy Manbawi"));
            Assert.That(_passenger.getGender().Equals("Female"));
            Assert.That(_passenger.getTicketType().Equals("Bus"));
        }

        [Test]
        public void PassengerTicketType_MethodIsCalled_ReturnTicketType()
        {
            // Arrange
            // Act
            // Assert
            Assert.That(_passenger.getTicketType().Equals("Bus"));

        }

        [Test]
        [Ignore("Ignore this test")]
        public void IgnoreTest()
        {

        }
    }
}
