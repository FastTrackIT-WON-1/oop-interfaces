namespace InterfaceExercises
{
    public interface IShape : IObjectWithArea, ITranslatableObject, IRotatableObject
    {
        void Print();
    }
}
