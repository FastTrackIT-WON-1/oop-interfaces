using System;

namespace InterfaceExercises
{
    public class Point : ITranslatableObject, IRotatableObject
    {
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; private set; }

        public double Y { get; private set; }

        public void Move(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }

        public void Rotate(double angleDegrees)
        {
            double angleRadians = (Math.PI / 180) * angleDegrees;

            // see: https://en.wikipedia.org/wiki/Rotation_matrix

            double originalX = this.X;
            double originalY = this.Y;

            this.X = (originalX * Math.Cos(angleRadians) - originalY * Math.Sin(angleRadians));
            this.Y = (originalX * Math.Sin(angleRadians) + originalY * Math.Cos(angleRadians));
        }
    }
}
