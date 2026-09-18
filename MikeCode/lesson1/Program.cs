class Program
{
    static void Main()
    {
        // Create a carClass object.
        carClass car = new carClass();

        // Create a carOwner object.
        carOwner person = new carOwner();

        // Set the car's speed.
        car.speed = 30;

        // Connect the car object to the owner object.
        // Now car.person points to the same person object.
        car.person = person;

        // Access the owner object through the car object
        // and assign a value to its name.
        car.person.name = "John Doe";

        // Access the owner through the car
        // and print the owner's name.
        Console.WriteLine("Car Owner Name: " + car.person.name);
    }
}

/*
    ==================== OBJECT COMPOSITION / OBJECT REFERENCE ====================

    The idea here is that one class can contain a reference to an object of another
    class.

    We have two classes:

        1. carClass  -> describes a car
        2. carOwner  -> describes the owner of a car

    In carClass we write:

        public carOwner person;

    This means a carClass object has a reference called "person" that can point
    to a carOwner object.

    IMPORTANT:
        "public carOwner person;" does NOT create a carOwner object.
        It only creates a reference that can store the address/reference of a
        carOwner object.

    ------------------------------------------------------------

    In the Program:

        carClass car = new carClass();

    This creates a carClass object called "car".

        carOwner person = new carOwner();

    This creates a separate carOwner object called "person".

    Now we connect the two objects:

        car.person = person;

    This means:
        "The person/owner of this car is the carOwner object called person."

    Now we can access the owner THROUGH the car:

        car.person.name = "John Doe";

    Read this from left to right:

        car
          ↓
        person
          ↓
        name

    So:
        car.person       = access the owner object inside the car
        car.person.name  = access the owner's name

    Therefore:

        car.person.name = "John Doe";

    means:
        Go to the car object
        → go to its owner object
        → change the owner's name to "John Doe".

    And:

        Console.WriteLine(car.person.name);

    means:
        Go to the car
        → access its owner
        → access the owner's name
        → print the name.

    ------------------------------------------------------------

    SIMPLE WAY TO REMEMBER:

        carClass
           |
           | person
           ↓
        carOwner
           |
           | name
           ↓
        "John Doe"

    This is called OBJECT COMPOSITION / HAS-A RELATIONSHIP.

    We can say:

        A car HAS-A car owner.

    The important concept is that "car.person" is a reference to another
    object, allowing us to access that object's data and methods through
    the car object.

    Example:

        car.person.name
        car.person.age
        car.person.ownerDetails();

    All of these access the carOwner object through the car object.
*/