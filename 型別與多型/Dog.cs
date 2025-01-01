namespace 型別與多型;

public class Dog : Animal
{
    public string Food { get; set; }

    public Dog()
    {
        Name = "Unknown";
        Food = "meat";
    }

    public Dog(string name)
        : this()
    {
        Name = name;
    }

    public string Sound()
    {
        return $"{Name} bark";
    }
}
