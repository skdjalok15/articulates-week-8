public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void makeSound()
    {
        Console.WriteLine("This animal makes a sound.");
    }
}

public class Dog : Animal
{
    public void bark()
    {
        Console.WriteLine("Woof! Woof!");
    }
}
