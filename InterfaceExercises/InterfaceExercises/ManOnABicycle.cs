using System;

namespace InterfaceExercises
{
    public class ManOnABicycle : IMovableMachine, IMovableBeing
    {
        void IMovableMachine.Move()
        {
            Console.WriteLine("ManOnABicycle - the bicycle is moving");
        }

        void IMovableBeing.Move()
        {
            Console.WriteLine("ManOnABicycle - the man is moving");
        }
    }
}
