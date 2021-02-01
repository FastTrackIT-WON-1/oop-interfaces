using System;
using System.Text;

namespace InterfaceExercises
{
    public abstract class Shape : IShape
    {
        protected Shape(params Point[] points)
        {
            if ((points is null) || (points.Length == 0))
            {
                throw new ArgumentException("Points collection must be non-null / non-empty", nameof(points));
            }

            Points = points ?? new Point[0];
        }

        public abstract string Name { get; }

        public Point[] Points { get; }

        public abstract double GetArea();

        public void Move(int dx, int dy)
        {
            foreach (Point p in Points)
            {
                p.Move(dx, dy);
            }
        }

        public void Print()
        {
            StringBuilder pointsCoords = new StringBuilder();
            pointsCoords.Append("[");

            foreach (Point p in Points)
            {
                pointsCoords.Append($"(X={p.X}, Y={p.Y}),");
            }

            pointsCoords.Append("]");

            Console.WriteLine($"{Name}: Area={GetArea()}, Points={pointsCoords}");
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
