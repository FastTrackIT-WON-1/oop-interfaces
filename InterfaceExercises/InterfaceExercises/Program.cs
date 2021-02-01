using System;

namespace InterfaceExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(new Point(0, 0), 10, 20);
            Triangle t = new Triangle(new Point(15, 15), new Point(23, 30), new Point(50, 25));

            PrintShapes(r, t);

            MoveObjects(100, 100, r, t);

            PrintShapes(r, t);
        }

        private static void PrintShapes(params IShape[] objects)
        {
            foreach (IShape o in objects)
            {
                o.Print();
            }
        }

        private static void MoveObjects(int dx, int dy, params ITranslatableObject[] objects)
        {
            foreach (ITranslatableObject o in objects)
            {
                o.Move(dx, dy);
            }
        }


        private static void PrintArea(params IObjectWithArea[] objects)
        {
            foreach (IObjectWithArea o in objects)
            {
                Console.WriteLine($"Area={o.GetArea()}");
            }
        }

        private static void MoveMachine(IMovableMachine movableMachine)
        {
            movableMachine.Move();
        }

        private static void MoveBeing(IMovableBeing movableBeing)
        {
            movableBeing.Move();
        }
    }
}
