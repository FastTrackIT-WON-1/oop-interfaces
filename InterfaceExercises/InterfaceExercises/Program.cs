using System;

namespace InterfaceExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(new Point(0, 0), 10, 20);

            MoveObjects(100, 100, r);

            PrintArea(r);
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
    }
}
