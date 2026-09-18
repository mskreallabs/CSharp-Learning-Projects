class carOwner
{
    // These variables store information about the car owner.
    public string name;
    public int age;
    public int price;

    // This method displays the owner's information.
    public void ownerDetails()
    {
        Console.WriteLine("Owner Details:");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Price: " + price);
    }
}