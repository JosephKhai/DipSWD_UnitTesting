using System;
using NUnit.Framework;
using DipTestingExercises;
using DipTestingExercise.Testing.Mocking;

namespace DipTestingExercise.Testing
{
    [TestFixture]
    public class BusTest
    {
        private Bus _bus;
        private IPerson _person;
        private Passenger _passenger;

        [SetUp]
        public void SetUp()
        {
            _bus = new Bus(_person, 100, 50, 2, 1);
            _passenger = new FakePassenger("Christy", "Manbawi", "Female", "Bus");
        }

        [Test]
        public void Constructor_MethodIsCalled_CheckMaxPassenger()
        {
            // arrange
            // act

            // Assert
            Assert.That(_bus.maxPassengers.Equals(1));

        }

        [Test]
        public void GetPassengerCount_BusIsEmpty_ShouldReturn_0()
        {
            // arrange
            // act         
            var result = _bus.getPassengerCount();
            // Assert
            Assert.That(result.Equals(0));

        }


        [Test]
        public void GetPassengerCount_BusHasPassenger_ShouldReturn_1()
        {
            // arrange
            // act         
            _bus.passengers.Add(_passenger);
            var result = _bus.getPassengerCount();
            // Assert
            Assert.That(result.Equals(1));

        }

        [Test]
        public void EmbarkPassenger_ButHasRoomForPassnger_AddaPassenger_ListShouldBeThe_FakePassenger()
        {
            // arrange
            // act         
           _bus.embarkPassenger(_person);
            var result = _bus.getPassengerCount();
            // Assert
            Assert.That(result.Equals(1));

        }

        [Test]
        public void Embark_2Passenger_AfterSecondCall_ExceptionThrown_BusIsFull_EmbarkPassengerIs_2()
        {
            try
            {
                _bus.embarkPassenger(_person);
                
            }
            catch(Exception e)
            {
                Assert.That(e.Message.Contains("Bus Full Num passenger embarked is 1"));
            }

        }

    }

   
}
