namespace 型別與多型;

public class Dog
{
    private string _name;

    public string Food { get; set; }

    public Dog()
    {
        _name = "Unknown";
        Food = "meat";
    }

    public Dog(string name): this()
    {
        _name = name;
    }

    public string Sound()
    {
        return $"{_name} bark";
    }
}
