Console.WriteLine("Name your dog");
string myDogName = Console.ReadLine();
Dog myDog = new Dog(myDogName); //nimetan oma koera ise

Dog neighboursDog = new Dog("Good girl"); //myDog ja neighboursDog on objektid ja need on kaks erinevat asja vahemalus


Console.WriteLine($"My dogs name is {myDog.Name}.");
Console.WriteLine($"My neighbours dogs name is {neighboursDog.Name}.");

myDog.Rename("Bad boy");

while (myDog.LevelOfHappiness != 5)
{
    myDog.Bark();
}

myDog.WagTail();


class Dog
{
    private string _name; //field
    private int _levelOfHappiness;

    //constructor
    public Dog(string name) //name - let's the user name the dog
    {
        _name = name;
        _levelOfHappiness = 0;
    }

    //getter

    public string Name //paasen ligi Name omadusele
    {
        get { return _name; } //tagastab vaartuse vahemalusse
    }

    public int LevelOfHappiness
    {
        get { return _levelOfHappiness; }
    }

    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has been renamed to: {newName}");
    }

    public void Bark()
    {
        Console.WriteLine("woof-woof!");
        _levelOfHappiness++;
    }

    public void WagTail()
    {
        Console.WriteLine("Wiggle-wiggle!");
    }
}
