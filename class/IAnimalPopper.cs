
public interface IAnimalPopper<out T>
{
    int Count { get; }

    //husk stor bokstav din kødd i methods.
    T Pop();
}