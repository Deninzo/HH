using System;

namespace GeometryLibrary.Models
{
    public class Circle : Figure
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        private double _radius;

        public double Radius
        {
            get => _radius;
            set
            {
                if(value <= 0)
                    throw new ArgumentOutOfRangeException();

                _radius = value;
            }
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
