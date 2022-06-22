using NUnit.Framework;
using Appl_TestsUnitaires;

namespace App_TestsUnitaires_Tests_NU
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetOutput_Div3And5_ReturnFizzBuzz()
        {
            // Arrange
            int nbr = 45;
            // Act
            var Result = E1_FizzBuzz.GetOutput(nbr);
            // Assert
            // par défaut: sensible aux majuscules/minuscules
            Assert.That(Result, Is.EqualTo("FizzBuzz"));
        }
        [Test]
        public void GetOutput_Div3_ReturnFizz()
        {
            // Arrange
            int nbr = 9;
            // Act
            var Result = E1_FizzBuzz.GetOutput(nbr);
            // Assert
            // Insensible aux majuscules/minuscules 
            Assert.That(Result, Is.EqualTo("fizz").IgnoreCase);

        }
        [Test]
        public void GetOutput_Div5_ReturnFizz()
        {
            // Arrange
            int nbr = 25;
            // Act
            var Result = E1_FizzBuzz.GetOutput(nbr);
            // Assert
            // Insensible aux majuscules/minuscules 
            Assert.That(Result, Is.EqualTo("buzz").IgnoreCase);
        }

        [Test]
        public void GetOutput_NonDiv3OrDiv5_ReturnParametre()
        {
            // Arrange
            int nbr = 26;
            // Act
            var Result = E1_FizzBuzz.GetOutput(nbr);
            // Assert
            Assert.AreEqual(Result, nbr.ToString());
        }

    }
}