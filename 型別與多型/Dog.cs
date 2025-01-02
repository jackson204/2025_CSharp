namespace 型別與多型;

public class Dog : Animal
{
    public string Food { get; set; }

    public Dog()
        : base()
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

    public override string Sound2()
    {
        return $"{Name} bark";
    }

    public string Play() => "Playing";

    public string Play(string toy) => $"Playing {toy}";

    public int Play(int time)
    {
        var result = 0;
        for(int i = 0; i < time; i++)
        {
            result += i;
        }
        return result;
    }

    protected override string Eat()
    {
        return "Dog is eating";
    }

    public string Eat2()
    {
        return Eat();
    }
}
