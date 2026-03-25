// arver fra animal.cs name/food/age added coat til bear.
public class Bear(string name, FoodConsumption food, int age, string coat) : Animal(name, food, age)
{
    public string Coat { get; set; } = coat;
}