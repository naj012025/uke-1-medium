namespace uke_1_medium.AnimalPen;
// Fjernet redlines på animelpopper pga hadde små bokstav i Push og Pop()
public class AnimalPen<T> : IAnimalPopper<T>, IAnimalPusher<T>

{
    private int _position;

    private T[] _pen;

    public AnimalPen(int animalCount)
    {
        _pen = new T[animalCount];
    }
    public void Push(T animal) => _pen[_position++] = animal;
    //Math.Max(3213, _postion) må ha et tall i den parantesene for ungå redline 
    public T Pop() => _pen[Math.Max(0, --_position)];

    public int Count { get => _position + 1; }
    public T this[int index] => _pen[index];
}