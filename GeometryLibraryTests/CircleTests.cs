using System;
using System.Collections.Generic;
using System.Text;
using GeometryLibrary.Models;
using NUnit.Framework;

namespace GeometryLibraryTests
{
    public class CircleTests
    {
        private Circle _circle;
        [OneTimeSetUp]
        public void Setup()
        {
            _circle = new Circle(3.1415);
        }

        [Test]
        public void ReturnCorrectArea()
        {
            Assert.AreEqual(31.00444779871421, _circle.CalculateArea(), 0.0001);
        }

        [Test]
        public void ThrowArgumentOutOfRange_WhenRadiusZero()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _circle.Radius = 0);
        }

        [Test]
        public void ThrowArgumentOutOfRange_WhenSetRadiusLessThanZero()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _circle.Radius = -5);
        }

    }
}
