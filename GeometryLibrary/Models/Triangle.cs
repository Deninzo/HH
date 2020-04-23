using System;
using System.Collections.Generic;
using System.Linq;

namespace GeometryLibrary.Models
{
    public class Triangle : Figure
    {
        public Triangle(double leftSide, double rightSide, double baseSide)
        {
            LeftSide = leftSide;
            RightSide = rightSide;
            Base = baseSide;
        }

        private double _leftSide;
        public double LeftSide
        {
            get => _leftSide;
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException();

                _leftSide = value;
            }
        }

        private double _rightSide;
        public double RightSide
        {
            get => _rightSide;
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException();

                _rightSide = value;
            }
        }

        private double _base;
        public double Base
        {
            get => _base;
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException();

                _base = value;
            }
        }

        public override double CalculateArea()
        {
            var halfPerimeter = (LeftSide + RightSide + Base) / 2;
            var area = Math.Sqrt(halfPerimeter * (halfPerimeter - LeftSide) * (halfPerimeter - RightSide) *
                                 (halfPerimeter - Base));
            return area;
        }

        public bool CheckIfRectangular()
        {
            var sidesList = new List<double> {LeftSide, RightSide, Base};
            var maxSide = sidesList.Max();
            var indexOfMax = sidesList.IndexOf(maxSide);
            sidesList.RemoveAt(indexOfMax);
            var cat = (Math.Pow(sidesList[0], 2) + Math.Pow(sidesList[1], 2));
            var gip = Math.Pow(maxSide, 2);
            return Math.Abs(gip - cat) < 0.0001;
        }
    }
}
