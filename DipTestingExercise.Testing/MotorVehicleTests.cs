using System;
using NUnit.Framework;
using DipTestingExercises;
using DipTestingExercise.Testing.Mocking;



namespace DipTestingExercise.Testing
{
    [TestFixture]
    public class MotorVehicleTests
    {
        private MotorVehicle _mv;
        private IPerson _person;

        

        [SetUp]
        public void Setup()
        {
            _person = new FakePerson("John", "Smith","Male");
            _mv = new FakeMotorVehicle(_person, 100, 50, 2);

            

        }

        [Test]
        public void MotorVehicle_IsCalled_AttributerAreSet()
        {
            // act

            // assert
            Assert.That(_mv.maxFuel.Equals(100));
            Assert.That(_mv.currentFuel.Equals(50));
            Assert.That(_mv.litresPerKM.Equals(2));
            Assert.That(_mv.driver.Equals(_person));
        }

        [Test]
        public void GetFuelRemaining_IsCalled_ReturnsCurrentFuel()
        {
            // arrange

            // act
            var result = _mv.getFuelRemaining();

            // assert
            Assert.That(_mv.currentFuel.Equals(result));
            
        }

        [Test]
        public void Refuel_HasEnoughRoom_FuelIsAdded()
        {
            // arrange

            // act
            _mv.refuel(50);
            var result = _mv.currentFuel;

            // assert
            Assert.That(result.Equals(100));
        }


        [Test]
        public void Refuel_NotEnoughRoom_CorrectExceptionThrown()
        {
            try
            {
                _mv.refuel(51);
                Assert.Fail();
            }
            catch(Exception e)
            {
                Assert.That(e.Message.Contains("cannot hold that much fuel"));
            }
        }

        [Test]
        public void Refuel_AttemptToAdd_VeAmountOfFuel_ExceptionThrown()
        {
            try
            {
                _mv.refuel(-1);
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.That(e.Message.Contains("stealing fuel"));
            }
        }

        [Test]
        public void TravelVehicleHasEnoughToTravel_IndicateDistance_getFuelRamaining()
        {
            // arrange

            // act
            _mv.travel(10);
            var result = _mv.currentFuel;

            // assert
            Assert.That(result.Equals(30));
        }


        [Test]
        public void VehicleDoesNotHaveEnoughFuel_ToTravelIndicatedDistance_getFuelRemaining()
        {

            try
            {
                _mv.travel(26);
                var result = _mv.currentFuel;
                Assert.That(result.Equals(0));
            }
            catch (Exception e)
            {
                
            }

        }

       




    }
}
