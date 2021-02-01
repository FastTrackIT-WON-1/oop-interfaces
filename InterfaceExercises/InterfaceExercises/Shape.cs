using System;

namespace InterfaceExercises
{
    public abstract class Shape : IObjectWithArea, ITranslatableObject, IRotatableObject
    {
        protected Shape(params Point[] points)
        {
            if ((points is null) || (points.Length == 0))
            {
                throw new ArgumentException("Points collection must be non-null / non-empty", nameof(points));
            }

            Points = points ?? new Point[0];
        }

        public Point[] Points { get; }

        public abstract double GetArea();

        public void Move(int dx, int dy)
        {
            foreach (Point p in Points)
            {
                p.Move(dx, dy);
            }
        }

        public void Rotate(double angleDegrees)
        {
            foreach (Point p in Points)
            {
                p.Rotate(angleDegrees);
            }
        }
    }
}
