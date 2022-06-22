using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appl_TestsUnitaires;
using NUnit.Framework;

namespace App_TestsUnitaires_Tests_NU
{
    [TestFixture]
    public class E3_AttackPoints_Tests
    {
        E3_AttackPointsCalculator _zombieAttack;
        [SetUp]
        public void SetUp()
        {
            _zombieAttack = new E3_AttackPointsCalculator();
        }
        [Test]
        [TestCase(0, 0)]
        [TestCase(6, 0)]
        [TestCase(19, 0)]
        [TestCase(20, 0)]
        [TestCase(21, 0)]
        [TestCase(25, 1)]
        [TestCase(30, 2)]
        [TestCase(85, 13)]
        public void AttackPointsCalculator_ReturnPoints(int nbrAttack, int expectedResult)
        {
            //Act
            var result = _zombieAttack.CalculateAttackPoints(nbrAttack);

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(-1)]
        [TestCase(205)]
        public void AttackPointsCalculator_ThrowArgumentOutOfRangeException(int nbrAttack)
        {
            // Act et Assert
            Assert.That(() => _zombieAttack.CalculateAttackPoints(nbrAttack), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());

        }
    }
}
