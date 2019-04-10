using System;
using NUnit.Framework;
using DipTestingExercises;
using DipTestingExercise.Testing.Mocking;

namespace DipTestingExercise.Testing
{
    [TestFixture]
    public class PersonTest
    {
        private Person _person;
       
        [SetUp]
         public void Setup()
         {
            _person = new FakePerson("John", "Smith", "Male");            

         }

         [Test]
         public void PersonConstructor_MethodIsCalled_CheckgetNameAndgetGender_AreCorrect()
         {
            // arrange
            // act
            // assert
            Assert.That(_person.getName().Equals("John Smith"));
            Assert.That(_person.getGender().Equals("Male"));

        }

        [Test]
        public void PersonGetName_CalledGetNameMethod_ExceptionThrown_NameDoesnotExist()
        {
            try
            {
                _person.getName().Equals("John Doe");
               
            }
            catch(Exception e)
            {
                Assert.That(e.Message.Contains("Name doesn't exist"));
            }       
            

        }

        [Test]
        public void PersonGetGender_CalledGetGenderMethod()
        {
            // arrange
            // act
            // assert
            
            Assert.That(_person.getGender().Equals("Male"));

        }




    }
}
