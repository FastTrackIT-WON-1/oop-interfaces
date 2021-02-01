using System;

namespace InterfaceExercises
{
    public class Rectangle : Shape
    {
        /*
         *   0
         * 0 ------------------------------------------> X
         *   |
         *   |
         *   |
         *   |
         *   |
         *   Y
         */

        public Rectangle(Point topLeft, double width, double height)
            : base(
                  topLeft, // top left
                  new Point(topLeft.X + width, topLeft.Y), // top - right
                  new Point(topLeft.X, topLeft.Y + height), // bottom - left
                  new Point(topLeft.X + width, topLeft.Y + height))
        {
            Width = width;
            Height = height;
        }

        public double Width { get; }

        public double Height { get; }

        public override string Name { get { return "Rectangle"; } }

        public override double GetArea()
        {
            return this.Height * this.Width;
        }
    }
}
