using uke_1_medium.AnimalPen;

public class ZooFeeder
{
    public static void Feed<T>(IAnimalPopper<T> animals)

    where T : Animal
    {
        for (int i = 0; i < animals.Count; i++)
        {
            var animal = animals.Pop();

            var food = animal.Consumption
            switch
            {
                FoodConsumption.Herbivore => " a fresh salad.",

                FoodConsumption.Carnivore => "a nice juicy salmon",

                FoodConsumption.Omnivore => "anything we could find, really",

                _ => "this food type is not registerd"
            };

            Console.WriteLine($"Feed the Animal {animal.Name} {food}");
        }
    }
}