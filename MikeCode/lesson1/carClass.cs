
class carClass
{
    // These variables store information about the car.
    public string name;
    public string model;
    public int price;
    public int speed;

    // This creates a reference that can point to a carOwner object.
    // In other words: this car has an owner.
    public carOwner person;

    // This method displays the car's information.
    public void carDetails()
    {
        Console.WriteLine("Car Details:");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Price: " + price);
        Console.WriteLine("Speed: " + speed);
    }
}