using System;
using System.Collections.Generic;
using System.Text;
using GeometryLibrary.Models;
using NUnit.Framework;

namespace GeometryLibraryTests
{
    public class TriangleTests
    {
        private Triangle _triangle;

        [OneTimeSetUp]
        public void Setup()
        {
            _triangle = new Triangle(15.6204993518, 10, 12);
        }

        [Test]
        public void CalculateAreaCorrect()
        {
            Assert.AreEqual(60, _triangle.CalculateArea(), 0.00001);
        }

        [Test]
        public void CheckIfRectangularWorkCorrect_WhenResultShouldBeTrue()
        {
            Assert.IsTrue(_triangle.CheckIfRectangular());
        }

        [Test]
        public void CheckIfRectangularWorkCorrect_WhenResultShouldBeFalse()
        {
            var oldValue = _triangle.Base;
            _triangle.Base = 42.4242;
            Assert.IsFalse(_triangle.CheckIfRectangular());
            _triangle.Base = oldValue;
        }

        [Test]
        public void ThrowArgumentOutOfRange_WhenTryMakeSideLessThanZero()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _triangle.Base = -10);
        }
    }
}
